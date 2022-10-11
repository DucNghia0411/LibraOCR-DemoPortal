using CoreOCR.API.VehicleRegistration;
using CoreOCR.Model.VehicleRegistrations;
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
    public class VehicleRegisController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly OCRContext _oCRContext;
        private readonly IVehicleRegistrationsAPI _vehicleRegistration;

        public VehicleRegisController(IHttpClientFactory httpClientFactory,
            IHttpContextAccessor httpContextAccessor,
            IConfiguration configuration,
            OCRContext oCRContext,
            IVehicleRegistrationsAPI vehicleRegistrations)
        {
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
            _httpClientFactory = httpClientFactory;
            _oCRContext = oCRContext;
            _vehicleRegistration = vehicleRegistrations;
        }
        public async Task<IActionResult> Index(int? SearchNo,  string SearchId, string SearchCreateDate, string SearchName, string SearchToDate)
        {
            var vhgInfo = from vhg in this._oCRContext.VehicleRegistrationsInfo
                          select vhg;

            if(SearchNo.HasValue)
            {
                vhgInfo = vhgInfo.Where(i => i.NumberOrder == SearchNo);
            }

            if (!string.IsNullOrEmpty(SearchId))
            {
                vhgInfo = vhgInfo.Where(i => i.Id!.ToString().Contains(SearchId));
            }

            if (!string.IsNullOrEmpty(SearchCreateDate) && string.IsNullOrEmpty(SearchToDate))
            {
                if (DateTime.TryParse(SearchCreateDate, out var created))
                {
                    vhgInfo = vhgInfo.Where(i => i.CreateDate == created);
                }
            }

            if (!string.IsNullOrEmpty(SearchCreateDate) && !string.IsNullOrEmpty(SearchToDate))
            {
                if (DateTime.TryParse(SearchCreateDate, out var created) && DateTime.TryParse(SearchToDate, out var todate))
                {
                    vhgInfo = vhgInfo.Where(i => i.CreateDate >= created && i.CreateDate <= todate);
                }
            }

            if (!string.IsNullOrEmpty(SearchName))
            {
                vhgInfo = vhgInfo.Where(i => i.FileName!.Contains(SearchName));
            }

            var vhgInfoVM = new VehicleRegistrationSearchInfoVM
            {
                VehicleRegistrations = await vhgInfo.ToListAsync()
            };

            return View(vhgInfoVM);
        }

        [HttpGet]
        public IActionResult Info()
        {
            return View();
        }
        [HttpPost]
        public async Task<string> GetInfo(IFormFile file)
        {
            string dtList = await this._vehicleRegistration.ReadVehicleRegistration(file);
            return dtList;
        }
        [HttpPost]
        public async Task<string> Save(IFormFile file, int imageSize, string jsonValue, string htmlValue)
        {
            List<string> strings = new List<string>();
            string currentPath = "wwwroot/images/";
            string savePath = "images/";
            string uploads = Path.Combine(currentPath, "vehicleregisters");
            Directory.CreateDirectory(uploads);
            if (file.Length < 0)
            {
                return "No file uploaded";
            }
            //save file image
            string filePath = Path.Combine(uploads, file.FileName);
            string envPath = Path.Combine(savePath, "vehicleregisters/") + file.FileName;
            try
            {
                using (Stream fileStream = System.IO.File.Create(filePath))
                {
                    await file.CopyToAsync(fileStream);
                }
            }
            catch (Exception e)
            {
                return e.Message.ToString();
            }

            VehicleRegistrationVM vehicleRegistrations = new VehicleRegistrationVM();
            vehicleRegistrations.ImagePath = envPath;
            vehicleRegistrations.FileName = file.FileName;
            vehicleRegistrations.ImageSize = imageSize;
            vehicleRegistrations.CreateDate = DateTime.Now;
            vehicleRegistrations.Value = jsonValue;
            vehicleRegistrations.HTMLValue = htmlValue;
            _oCRContext.Add(vehicleRegistrations);
            await _oCRContext.SaveChangesAsync();
            return jsonValue;
        }
        [HttpPost]
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _oCRContext.VehicleRegistrationsInfo == null)
            {
                return NotFound();
            }
            var info = await _oCRContext.VehicleRegistrationsInfo.FirstOrDefaultAsync(m => m.Id == id);
            if (info == null)
            {
                return NotFound();
            }
            ViewData["Info"] = info;
            return PartialView("_Details",info);
        }

        public async Task<IActionResult> Delete(Guid? id)
        {
            var info = await _oCRContext.VehicleRegistrationsInfo.FindAsync(id);
            if (info != null)
            {
                _oCRContext.VehicleRegistrationsInfo.Remove(info);
            }
            await _oCRContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
