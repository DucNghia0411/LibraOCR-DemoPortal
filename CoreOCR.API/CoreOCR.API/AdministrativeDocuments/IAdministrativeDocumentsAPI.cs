using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOCR.API.AdministrativeDocuments
{
    public interface IAdministrativeDocumentsAPI
    {
        public Task<string> ReadAdministrativeDocuments(IFormFile file);
        public Task<string> ReadAdministrativeDocumentsPDF(IFormFile file);

    }
}
