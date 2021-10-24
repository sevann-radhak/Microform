using System;
using System.Collections.Generic;

namespace Microform.Functions.Data.Entities
{
    public class ApplicationPayerTokenEntity
    {
        public int Id { get; set; }
        public int ApplicationPayerInfoId { get; set; }
        public DateTime CreatedUtcTime { get; set; }
        public string InstrumentIdentifierTokenId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDefault { get; set; }
        public string PaymentInstrumentTokenId { get; set; }
        public string ShippingAddressTokenId { get; set; }
        public DateTime? UpdatedUtcTime { get; set; }

        public virtual ApplicationPayerInfoEntity ApplicationPayerInfo { get; set; }
    }
}
