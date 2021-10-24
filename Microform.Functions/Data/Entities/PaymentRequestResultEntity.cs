using System;

namespace Microform.Functions.Data.Entities
{
    public class PaymentRequestResultEntity
    {
        public int Id { get; set; }
        public DateTime CreatedUtcTime { get; set; }
        public int PaymentRequestId { get; set; }
        public string ResultId { get; set; }
        public int StatusId { get; set; }

        public virtual PaymentRequestEntity PaymentRequest { get; set; }
        public virtual PaymentRequestStatusEntity PaymentRequestStatus { get; set; }
    }
}
