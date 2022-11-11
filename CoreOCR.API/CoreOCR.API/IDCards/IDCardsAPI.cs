using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CoreOCR.API.IDCards
{
    public class IDCardsAPI : BaseApiClient , IIDCardsAPI
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public IDCardsAPI(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<string> ReadIDCards(IFormFile file)
        {
            var body = await AddFileIDCAsync("cmnd_img", file);

            return body;
        }
    }
}
