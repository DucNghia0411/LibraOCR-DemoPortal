using CoreOCR.Model;
using CoreOCR.Model.HealthRecords;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOCR.API.HealthRecords
{
    public interface IHealthRecordsAPI
    {
        public Task<string> ReadHealthRecords(IFormFile file);
    }
}
