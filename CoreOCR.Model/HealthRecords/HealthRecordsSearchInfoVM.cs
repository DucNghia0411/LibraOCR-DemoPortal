using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CoreOCR.Model.HealthRecords
{
    public class HealthRecordsSearchInfoVM
    {
        public List<HealthRecordsVM> HealthRecords { get; set; }
        public string searchNo { get; set; }
        public string SearchId { get; set; }
        public string SearchName { get; set; }
        public DateTime SearchCreateDate { get; set; }
        public DateTime SearchToDate { get; set; }

    }
}
