using CoreOCR.Model.AdministrativeDocuments;
using CoreOCR.Model.HealthRecords;
using CoreOCR.Model.IDCards;
using CoreOCR.Model.VehicleRegistrations;
using Microsoft.EntityFrameworkCore;

namespace WebOCR.Datas
{
    public class OCRContext : DbContext
    {
        public OCRContext(DbContextOptions<OCRContext> options) : base(options)
        {
        }
        public DbSet<HealthRecordsVM> HealthRecordsInfo { get; set; }
        public DbSet<IDCardsVM> IDCardsInfo { get; set; }
        public DbSet<VehicleRegistrationVM> VehicleRegistrationsInfo { get; set; }
        public DbSet<AdministrativeDocumentsVM> AdministrativeDocumentsInfo { get; set; }
        public DbSet<AdministrativeDocumentsPDFVM> AdministrativeDocumentsPDFInfo { get; set; }
    }
}
