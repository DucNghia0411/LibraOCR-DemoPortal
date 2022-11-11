using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOCR.Model.AdministrativeDocuments
{
    public class AdministrativeDocumentsPDFSearchInfoVM
    {
        public List<AdministrativeDocumentsPDFVM> AdministrativeDocumentsPDF { get; set; }
        public string searchNo { get; set; }
        public string SearchId { get; set; }
        public string SearchName { get; set; }
        public DateTime SearchCreateDate { get; set; }
        public DateTime SearchToDate { get; set; }

    }
}
