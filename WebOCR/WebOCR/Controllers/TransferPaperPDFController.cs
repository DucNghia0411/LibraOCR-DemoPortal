using CoreOCR.API.AdministrativeDocuments;
using CoreOCR.API.TransferPaper;
using CoreOCR.Model.AdministrativeDocuments;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using WebOCR.Datas;
using System.Linq;
using CoreOCR.Model.TransferPaper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.IO;

namespace WebOCR.Controllers
{
    public class TransferPaperPDFController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly OCRContext _oCRContext;
        private readonly ITransferPaperAPI _transferPaper;
        public TransferPaperPDFController(IHttpClientFactory httpClientFactory,
            IHttpContextAccessor httpContextAccessor,
            IConfiguration configuration,
            OCRContext oCRContext,
            ITransferPaperAPI transferPaper)
        {
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
            _httpClientFactory = httpClientFactory;
            _oCRContext = oCRContext;
            _transferPaper = transferPaper;
        }
        public async Task<IActionResult> Index(int? SearchNo, string SearchId, string SearchCreateDate, string SearchName)
        {
            var tpInfo = from tf in this._oCRContext.TransferPaperPDFInfo
                         select tf;

            if (SearchNo.HasValue)
            {
                tpInfo = tpInfo.Where(i => i.NumberOrder == SearchNo);
            }

            if (!string.IsNullOrEmpty(SearchId))
            {
                tpInfo = tpInfo.Where(i => i.Id!.ToString().Contains(SearchId));
            }

            if (!string.IsNullOrEmpty(SearchCreateDate))
            {
                if (DateTime.TryParse(SearchCreateDate, out var created))
                {
                    tpInfo = tpInfo.Where(i => i.CreateDate == created);
                }
            }

            if (!string.IsNullOrEmpty(SearchName))
            {
                tpInfo = tpInfo.Where(i => i.FileName!.Contains(SearchName));
            }

            var tfInfoVM = new TransferPaperPDFSearchInfoVM
            {
                TransferPaperPDF = await tpInfo.ToListAsync()
            };

            return View(tfInfoVM);
        }
        [HttpGet]
        public IActionResult InfoPDF()
        {
            return View();
        }
        [HttpPost]
        public async Task<string> GetInfoPDF(IFormFile file)
        {
            string tList = await this._transferPaper.ReadTransferPaper(file);
            return tList;
        }
        [HttpPost]
        public async Task<string> SavePDF(IFormFile file, int imageSize, string jsonValue, string htmlValue)
        {
            List<string> strings = new List<string>();
            string currentPath = "wwwroot/pdf/";
            string savePath = "pdf/";
            string uploads = Path.Combine(currentPath, "tranferpaper");
            Directory.CreateDirectory(uploads);
            if (file.Length < 0)
            {
                return "No file uploaded";
            }
            //save file image
            string filePath = Path.Combine(uploads, file.FileName);
            string envPath = Path.Combine(savePath, "tranferpaper/") + file.FileName;
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
            TransferPaperPDFVM transferPaper = new TransferPaperPDFVM();
            transferPaper.PDFPath = envPath;
            transferPaper.FileName = file.FileName;
            transferPaper.PDFSize = imageSize;
            transferPaper.CreateDate = DateTime.Now;
            transferPaper.Value = jsonValue;
            transferPaper.HTMLValue = htmlValue;
            _oCRContext.Add(transferPaper);
            await _oCRContext.SaveChangesAsync();
            return jsonValue;
        }
        [HttpPost]
        public async Task<IActionResult> DetailsPDF(Guid? id)
        {
            if (id == null || _oCRContext.TransferPaperPDFInfo== null)
            {
                return NotFound();
            }
            var info = await _oCRContext.TransferPaperPDFInfo.FirstOrDefaultAsync(m => m.Id == id);
            if (info == null)
            {
                return NotFound();
            }
            ViewData["Info"] = info;
            return PartialView("_DetailsPDF", info);
        }
        public async Task<IActionResult> DeletePDF(Guid? id)
        {
            var info = await _oCRContext.TransferPaperPDFInfo.FindAsync(id);
            if (info != null)
            {
                _oCRContext.TransferPaperPDFInfo.Remove(info);
            }
            await _oCRContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
