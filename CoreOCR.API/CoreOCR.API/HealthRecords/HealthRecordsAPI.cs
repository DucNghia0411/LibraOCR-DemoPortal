using CoreOCR.API.Utilities;
using CoreOCR.Model;
using CoreOCR.Model.HealthRecords;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CoreOCR.API.HealthRecords
{
    public class HealthRecordsAPI : BaseApiClient , IHealthRecordsAPI
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public HealthRecordsAPI(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<string> ReadHealthRecords(IFormFile file)
        {
            var body = await AddFileHealthRecordsAsync("hssk_img", file);

            return body;
        }
    }
}
