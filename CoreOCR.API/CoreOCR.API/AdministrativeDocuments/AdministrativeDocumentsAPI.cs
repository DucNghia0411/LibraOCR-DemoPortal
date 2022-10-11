using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CoreOCR.API.AdministrativeDocuments
{
    public class AdministrativeDocumentsAPI : BaseApiClient, IAdministrativeDocumentsAPI
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public AdministrativeDocumentsAPI(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<string> ReadAdministrativeDocuments(IFormFile file)
        {
            var body = await AddFileAdministrativeDocumentsAsync("extract?service_name=gthc_img", file);

            return body;
        }
    }
}
