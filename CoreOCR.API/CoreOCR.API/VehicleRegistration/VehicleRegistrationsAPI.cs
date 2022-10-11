using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CoreOCR.API.VehicleRegistration
{
    public class VehicleRegistrationsAPI : BaseApiClient, IVehicleRegistrationsAPI
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public VehicleRegistrationsAPI(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<string> ReadVehicleRegistration(IFormFile file)
        {
            var body = await AddFileVehicleRegisAsync("extract?service_name=gtcn", file);

            return body;
        }
    }
}
