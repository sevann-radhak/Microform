using System;

namespace Microform.Functions.Data.Entities
{
    public class ApplicationRequestResultEntity
    {
        public int Id { get; set; }
        public int ApplicationRequestId { get; set; }
        public DateTime CreatedUtcTime { get; set; }
        public int ReturnDesicion { get; set; }
        public int StatusId { get; set; }

        public virtual ApplicationRequestStatusEntity ApplicationRequestStatus { get; set; }
        public virtual ApplicationRequestEntity ApplicationRequest { get; set; }
    }
}
