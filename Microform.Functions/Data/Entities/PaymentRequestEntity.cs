using System;

namespace Microform.Functions.Data.Entities
{
    public class PaymentRequestEntity
    {
        public int Id { get; set; }
        public int ApplicationRequestId { get; set; }
        public int PaymentRequestTypeId { get; set; }
        public string InstrumentIdentifierTokenId { get; set; }
        public string PaymentInstrumentTokenId { get; set; }
        public string ShippingAddressTokenId { get; set; }
        public DateTime CreatedUtcTime { get; set; }

        public virtual ApplicationRequestEntity ApplicationRequest { get; set; }
        public virtual PaymentRequestTypeEntity PaymentRequestType { get; set; }
    }
}
