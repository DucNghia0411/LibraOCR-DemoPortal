using CoreOCR.API.IDCards;
using CoreOCR.Model.IDCards;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebOCR.Datas;

namespace WebOCR.Controllers
{
    public class IDCardController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly OCRContext _oCRContext;
        private readonly IIDCardsAPI _iDCards;
        public IDCardController(IHttpClientFactory httpClientFactory,
            IHttpContextAccessor httpContextAccessor,
            IConfiguration configuration,
            OCRContext oCRContext,
            IIDCardsAPI iDCards)
        {
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
            _httpClientFactory = httpClientFactory;
            _oCRContext = oCRContext;
            _iDCards = iDCards;
        }
        public async Task<IActionResult> Index(int? SearchNo, string SearchId, string SearchCreateDate, string SearchName)
        {
            var idcInfo = from idc in this._oCRContext.IDCardsInfo
                          select idc;
            if (SearchNo.HasValue)
            {
                idcInfo = idcInfo.Where(i => i.NumberOrder == SearchNo);
            }

            if (!string.IsNullOrEmpty(SearchId))
            {
                idcInfo = idcInfo.Where(i => i.Id!.ToString().Contains(SearchId));
            }

            if (!string.IsNullOrEmpty(SearchCreateDate))
            {
                if (DateTime.TryParse(SearchCreateDate, out var created))
                {
                    idcInfo = idcInfo.Where(i => i.CreateDate == created);
                }
            }

            if (!string.IsNullOrEmpty(SearchName))
            {
                idcInfo = idcInfo.Where(i => i.FileName!.Contains(SearchName));
            }

            var idcInfoVM = new IDCardsSearchInfoVM
            {
                IDCards = await idcInfo.ToListAsync()
            };
            return View(idcInfoVM);
        }

        [HttpGet]
        public IActionResult Info()
        {
            return View();
        }
        [HttpPost]
        public async Task<string> GetInfo(IFormFile file)
        {
            string dtList = await this._iDCards.ReadIDCards(file);
            return dtList;
        }
        [HttpPost]
        public async Task<string> Save(IFormFile file, int imageSize, string jsonValue, string htmlValue)
        {
            List<string> strings = new List<string>();
            string currentPath = "wwwroot/images/";
            string savePath = "images/";
            string uploads = Path.Combine(currentPath, "idcards");
            Directory.CreateDirectory(uploads);
            if (file.Length < 0)
            {
                return "No file uploaded";
            }
            //save file image
            string filePath = Path.Combine(uploads, file.FileName);
            string envPath = Path.Combine(savePath, "idcards/") + file.FileName;
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

            IDCardsVM iDCards = new IDCardsVM();
            iDCards.ImagePath = envPath;
            iDCards.FileName = file.FileName;
            iDCards.ImageSize = imageSize;
            iDCards.CreateDate = DateTime.Now;
            iDCards.Value = jsonValue;
            iDCards.HTMLValue = htmlValue;
            _oCRContext.Add(iDCards);
            await _oCRContext.SaveChangesAsync();
            return jsonValue;
        }
        [HttpPost]
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _oCRContext.IDCardsInfo == null)
            {
                return NotFound();
            }
            var info = await _oCRContext.IDCardsInfo.FirstOrDefaultAsync(m => m.Id == id);
            if (info == null)
            {
                return NotFound();
            }
            ViewData["Info"] = info;
            return PartialView("_Details", info);
        }

        public async Task<IActionResult> Delete(Guid? id)
        {
            var info = await _oCRContext.IDCardsInfo.FindAsync(id);
            if (info != null)
            {
                _oCRContext.IDCardsInfo.Remove(info);
            }
            await _oCRContext.SaveChangesAsync();
            ModelState.Clear();
            return RedirectToAction("Index");
        }
    }
}
