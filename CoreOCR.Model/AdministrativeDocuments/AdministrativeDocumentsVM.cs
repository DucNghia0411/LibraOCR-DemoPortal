using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOCR.Model.AdministrativeDocuments
{
    public class AdministrativeDocumentsVM
    {
        public int NumberOrder { get; set; }
        public Guid Id { get; set; }
        public string ImagePath { get; set; }
        public int ImageSize { get; set; }
        public DateTime CreateDate { get; set; }
        public int? Status { get; set; }
        public float? Reliability { get; set; }
        public bool? Trained { get; set; }
        public string Value { get; set; }
        public string FileName { get; set; }
        public string HTMLValue { get; set; }
    }
}
