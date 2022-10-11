using CoreOCR.API.HealthRecords;
using CoreOCR.Model.HealthRecords;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using WebOCR.Datas;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.IO;

namespace WebOCR.Controllers
{
    public class HealthRecordsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly OCRContext _oCRContext;
        private readonly IHealthRecordsAPI _healthRecords;
        public HealthRecordsController(IHttpClientFactory httpClientFactory,
            IHttpContextAccessor httpContextAccessor,
            IConfiguration configuration,
            OCRContext oCRContext,
            IHealthRecordsAPI healthRecords)
        {
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
            _httpClientFactory = httpClientFactory;
            _oCRContext = oCRContext;
            _healthRecords = healthRecords;
        }
        public async Task<IActionResult> Index(int? SearchNo, string SearchId, string SearchCreateDate, string SearchName)
        {

            var hrInfo = from hr in this._oCRContext.HealthRecordsInfo
                         select hr;

            if (SearchNo.HasValue)
            {
                hrInfo = hrInfo.Where(i => i.NumberOrder == SearchNo);
            }

            if (!string.IsNullOrEmpty(SearchId))
            {
                hrInfo = hrInfo.Where(i => i.Id!.ToString().Contains(SearchId));
            }

            if (!string.IsNullOrEmpty(SearchCreateDate))
            {
                if (DateTime.TryParse(SearchCreateDate, out var created))
                {
                    hrInfo = hrInfo.Where(i => i.CreateDate == created);
                }
            }

            if (!string.IsNullOrEmpty(SearchName))
            {
                hrInfo = hrInfo.Where(i => i.FileName!.Contains(SearchName));
            }

            var hrInfoVM = new HealthRecordsSearchInfoVM
            {
                HealthRecords = await hrInfo.ToListAsync()
            };

            return View(hrInfoVM);
        }
        [HttpGet]
        public IActionResult Info()
        {
            return View();
        }
        [HttpPost]
        public async Task<string> GetInfo(IFormFile file)
        {
            string dtList = await this._healthRecords.ReadHealthRecords(file);
            return dtList;
        }
        [HttpPost]
        public async Task<string> Save(IFormFile file, int imageSize, string jsonValue, string htmlValue)
        {
            List<string> strings = new List<string>();
            string currentPath = "wwwroot/images/";
            string savePath = "images/";
            string uploads = Path.Combine(currentPath, "healthrecords");
            Directory.CreateDirectory(uploads);
            if (file.Length < 0)
            {
                return "No file uploaded";
            }
            //save file image
            string filePath = Path.Combine(uploads, file.FileName);
            string envPath = Path.Combine(savePath, "healthrecords/") + file.FileName;
            try
            {
                using (Stream fileStream = System.IO.File.Create(filePath))
                {
                    await file.CopyToAsync(fileStream);
                }
            }
            catch (Exception)
            {
                return "Cant save file";
            }

            HealthRecordsVM healthRecords = new HealthRecordsVM();
            healthRecords.ImagePath = envPath;
            healthRecords.FileName = file.FileName;
            healthRecords.ImageSize = imageSize;
            healthRecords.CreateDate = DateTime.Now;
            healthRecords.Value = jsonValue;
            healthRecords.HTMLValue = htmlValue;
            _oCRContext.Add(healthRecords);
            await _oCRContext.SaveChangesAsync();
            return jsonValue;
        }
        [HttpPost]
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _oCRContext.HealthRecordsInfo == null)
            {
                return NotFound();
            }
            var info = await _oCRContext.HealthRecordsInfo.FirstOrDefaultAsync(m => m.Id == id);
            if (info == null)
            {
                return NotFound();
            }
            ViewData["Info"] = info;
            return PartialView("_Details", info);
        }
        public async Task<IActionResult> Delete(Guid? id)
        {
            var info = await _oCRContext.HealthRecordsInfo.FindAsync(id);
            if (info != null)
            {
                _oCRContext.HealthRecordsInfo.Remove(info);
            }
            await _oCRContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
