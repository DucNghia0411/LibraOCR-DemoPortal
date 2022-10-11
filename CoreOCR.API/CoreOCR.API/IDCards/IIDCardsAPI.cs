using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOCR.API.IDCards
{
    public interface IIDCardsAPI
    {
        public Task<string> ReadIDCards(IFormFile file);
    }
}
