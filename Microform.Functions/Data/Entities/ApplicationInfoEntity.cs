using System;
using System.Collections.Generic;

namespace Microform.Functions.Data.Entities
{
    public class ApplicationInfoEntity
    {
        public int Id { get; set; }
        public string ApplicationKey { get; set; }
        public string ApplicationName { get; set; }
        public DateTime CreatedUtcTime { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<ApplicationRequestEntity> ApplicationRequests { get; set; }
    }
}
