using System;
using System.Collections.Generic;

namespace Microform.Functions.Data.Entities
{
    public class LocationInfoEntity
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedUtcTime { get; set; }
        public string LocationId { get; set; }
        public string LocationName { get; set; }
        public string MerchantId { get; set; }

        public virtual ICollection<ApplicationRequestEntity> ApplicationRequests { get; set; }
    }
}
