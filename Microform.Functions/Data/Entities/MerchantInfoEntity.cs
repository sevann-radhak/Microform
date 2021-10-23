using System;
using System.Collections.Generic;
using System.Text;

namespace Microform.Functions.Data.Entities
{
    public class MerchantInfoEntity
    {
        public int Id { get; set; }
        public DateTime CreatedUtcTime { get; set; }
        public string CybersourceId { get; set; }
        public bool IsActive { get; set; }
        public string MerchantId { get; set; }
        public string MerchantName { get; set; }
    }
}
