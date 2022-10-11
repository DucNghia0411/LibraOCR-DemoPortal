using CoreOCR.API.AdministrativeDocuments;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Net.Http;
using WebOCR.Datas;
using System.Linq;
using System;
using CoreOCR.Model.AdministrativeDocuments;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.IO;

namespace WebOCR.Controllers
{
    public class AdministrativeDocumentsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly OCRContext _oCRContext;
        private readonly IAdministrativeDocumentsAPI _administrativeDocuments;
        public AdministrativeDocumentsController(IHttpClientFactory httpClientFactory,
            IHttpContextAccessor httpContextAccessor,
            IConfiguration configuration,
            OCRContext oCRContext,
            IAdministrativeDocumentsAPI administrativeDocuments)
        {
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
            _httpClientFactory = httpClientFactory;
            _oCRContext = oCRContext;
            _administrativeDocuments = administrativeDocuments;
        }
        public async Task<IActionResult> Index(int? SearchNo, string SearchId, string SearchCreateDate, string SearchName)
        {
            var adInfo = from ad in this._oCRContext.AdministrativeDocumentsInfo
                         select ad;

            if (SearchNo.HasValue)
            {
                adInfo = adInfo.Where(i => i.NumberOrder == SearchNo);
            }

            if (!string.IsNullOrEmpty(SearchId))
            {
                adInfo = adInfo.Where(i => i.Id!.ToString().Contains(SearchId));
            }

            if (!string.IsNullOrEmpty(SearchCreateDate))
            {
                if (DateTime.TryParse(SearchCreateDate, out var created))
                {
                    adInfo = adInfo.Where(i => i.CreateDate == created);
                }
            }

            if (!string.IsNullOrEmpty(SearchName))
            {
                adInfo = adInfo.Where(i => i.FileName!.Contains(SearchName));
            }

            var adInfoVM = new AdministrativeDocumentsSearchInfoVM
            {
                AdministrativeDocuments = await adInfo.ToListAsync()
            };

            return View(adInfoVM);
        }
        [HttpGet]
        public IActionResult Info()
        {
            return View();
        }
        [HttpPost]
        public async Task<string> GetInfo(IFormFile file)
        {
            string dtList = await this._administrativeDocuments.ReadAdministrativeDocuments(file);
            return dtList;
        }
        [HttpPost]
        public async Task<string> Save(IFormFile file, int imageSize, string jsonValue, string htmlValue)
        {
            List<string> strings = new List<string>();
            string currentPath = "wwwroot/images/";
            string savePath = "images/";
            string uploads = Path.Combine(currentPath, "administrativedocuments");
            Directory.CreateDirectory(uploads);
            if (file.Length < 0)
            {
                return "No file uploaded";
            }
            //save file image
            string filePath = Path.Combine(uploads, file.FileName);
            string envPath = Path.Combine(savePath, "administrativedocuments/") + file.FileName;
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

            AdministrativeDocumentsVM administrativeDocuments = new AdministrativeDocumentsVM();
            administrativeDocuments.ImagePath = envPath;
            administrativeDocuments.FileName = file.FileName;
            administrativeDocuments.ImageSize = imageSize;
            administrativeDocuments.CreateDate = DateTime.Now;
            administrativeDocuments.Value = jsonValue;
            administrativeDocuments.HTMLValue = htmlValue;
            _oCRContext.Add(administrativeDocuments);
            await _oCRContext.SaveChangesAsync();
            return jsonValue;
        }
        [HttpPost]
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _oCRContext.AdministrativeDocumentsInfo == null)
            {
                return NotFound();
            }
            var info = await _oCRContext.AdministrativeDocumentsInfo.FirstOrDefaultAsync(m => m.Id == id);
            if (info == null)
            {
                return NotFound();
            }
            ViewData["Info"] = info;
            return PartialView("_Details", info);
        }
        public async Task<IActionResult> Delete(Guid? id)
        {
            var info = await _oCRContext.AdministrativeDocumentsInfo.FindAsync(id);
            if (info != null)
            {
                _oCRContext.AdministrativeDocumentsInfo.Remove(info);
            }
            await _oCRContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
