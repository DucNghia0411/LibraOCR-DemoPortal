using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOCR.Model.IDCards
{
    public class IDCardsSearchInfoVM
    {
        public List<IDCardsVM> IDCards{ get; set; }
        public string searchNo { get; set; }
        public string SearchId { get; set; }
        public string SearchName { get; set; }
        public DateTime SearchCreateDate { get; set; }
        public DateTime SearchToDate { get; set; }

    }
}
