namespace Microform.Functions.Data.Entities
{
    public class CybersourceConfigurationEntity 
    {
        public int Id { get; set; }
        public string AuthenticationType { get; set; }
        public string EnableLog { get; set; }
        public string KeyAlias { get; set; }
        public string KeysDirectory { get; set; }
        public string KeyFilename { get; set; }
        public string KeyPass { get; set; }
        public string MerchantID { get; set; }
        public string MerchantKeyId { get; set; }
        public string MerchantsecretKey { get; set; }
        public string RunEnvironment { get; set; }
    }
}
