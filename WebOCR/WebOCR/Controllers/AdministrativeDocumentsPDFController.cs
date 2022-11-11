using CoreOCR.API.AdministrativeDocuments;
using CoreOCR.Model.AdministrativeDocuments;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using WebOCR.Datas;
using System.Linq;

namespace WebOCR.Controllers
{
    public class AdministrativeDocumentsPDFController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly OCRContext _oCRContext;
        private readonly IAdministrativeDocumentsAPI _administrativeDocuments;
        public AdministrativeDocumentsPDFController(IHttpClientFactory httpClientFactory,
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
            var adInfo = from ad in this._oCRContext.AdministrativeDocumentsPDFInfo
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

            var adInfoVM = new AdministrativeDocumentsPDFSearchInfoVM
            {
                AdministrativeDocumentsPDF = await adInfo.ToListAsync()
            };

            return View(adInfoVM);
        }
        [HttpGet]
        public IActionResult InfoPDF()
        {
            return View();
        }
        [HttpPost]
        public async Task<string> GetInfoPDF(IFormFile file)
        {
            string tList = await this._administrativeDocuments.ReadAdministrativeDocumentsPDF(file);
            return tList;
        }
        [HttpPost]
        public async Task<string> SavePDF(IFormFile file, int imageSize, string jsonValue, string htmlValue)
        {
            List<string> strings = new List<string>();
            string currentPath = "wwwroot/pdf/";
            string savePath = "pdf/";
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
            AdministrativeDocumentsPDFVM administrativeDocuments = new AdministrativeDocumentsPDFVM();
            administrativeDocuments.PDFPath = envPath;
            administrativeDocuments.FileName = file.FileName;
            administrativeDocuments.PDFSize = imageSize;
            administrativeDocuments.CreateDate = DateTime.Now;
            administrativeDocuments.Value = jsonValue;
            administrativeDocuments.HTMLValue = htmlValue;
            _oCRContext.Add(administrativeDocuments);
            await _oCRContext.SaveChangesAsync();
            return jsonValue;
        }
        [HttpPost]
        public async Task<IActionResult> DetailsPDF(Guid? id)
        {
            if (id == null || _oCRContext.AdministrativeDocumentsPDFInfo == null)
            {
                return NotFound();
            }
            var info = await _oCRContext.AdministrativeDocumentsPDFInfo.FirstOrDefaultAsync(m => m.Id == id);
            if (info == null)
            {
                return NotFound();
            }
            ViewData["Info"] = info;
            return PartialView("_DetailsPDF", info);
        }
        public async Task<IActionResult> DeletePDF(Guid? id)
        {
            var info = await _oCRContext.AdministrativeDocumentsPDFInfo.FindAsync(id);
            if (info != null)
            {
                _oCRContext.AdministrativeDocumentsPDFInfo.Remove(info);
            }
            await _oCRContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
