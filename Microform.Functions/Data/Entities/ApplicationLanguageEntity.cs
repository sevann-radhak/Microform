using System.Collections.Generic;

namespace Microform.Functions.Data.Entities
{
    public class ApplicationLanguageEntity
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public string Language { get; set; }

        public virtual ICollection<ApplicationRequestEntity> ApplicationRequests { get; set; }
    }
}
