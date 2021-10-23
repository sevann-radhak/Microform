using System;

namespace Microform.Functions.Data.Entities
{
    public class ApplicationRequestEntity
    {
        public int Id { get; set; }
        public int ApplicationInfoId { get; set; }
        public int ApplicationPayerInfoId { get; set; }
        public DateTime CreatedUtcTime { get; set; }
        public int LanguageId { get; set; }
        public int LocationId { get; set; }
        public string MerchantId { get; set; }
        public string OrderInfo { get; set; }
        public string PaymentKey { get; set; }
        public string ReferenceId { get; set; }
        public string TransactionKey { get; set; }

        public virtual ApplicationInfoEntity ApplicationInfo { get; set; }
        public virtual ApplicationPayerInfoEntity ApplicationPayerInfo { get; set; }
        public virtual ApplicationLanguageEntity Language { get; set; }
        public virtual LocationInfoEntity Location { get; set; }
    }
}
