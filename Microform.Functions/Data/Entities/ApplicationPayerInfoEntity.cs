using System;
using System.Collections.Generic;

namespace Microform.Functions.Data.Entities
{
    public class ApplicationPayerInfoEntity
    {
        public int Id { get; set; }
        public DateTime CreatedUtcTime { get; set; }

        //TODO:
        // complete entity

        public virtual ICollection<ApplicationRequestEntity> ApplicationRequests { get; set; }
    }
}
