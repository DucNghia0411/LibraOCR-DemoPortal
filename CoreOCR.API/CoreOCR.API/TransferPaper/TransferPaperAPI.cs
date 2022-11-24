using CoreOCR.API.IDCards;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CoreOCR.API.TransferPaper
{
    public interface ITransferPaperAPI
    {
        Task<string> ReadTransferPaper(IFormFile file);
    }
    public class TransferPaperAPI : BaseApiClient, ITransferPaperAPI
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public TransferPaperAPI(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<string> ReadTransferPaper(IFormFile file)
        {
            var body = await AddFileTransferPaperAsync("giay_chuyen_truong_pdf", file);
            return body;
        }
    }
}
