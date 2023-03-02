using Newtonsoft.Json;
using POC.Models.FactoryEntity;
using POC.Models.LGAEntity;
using POC.Models.StateEntity;
using System.Collections.Generic;

namespace POC.Models.PocEntity
{
    public class Poc
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        //[JsonProperty("factory_location")]
        //public ICollection<FactoryLocation> FactoryLocation { get; set; }
        [JsonProperty("invoice_number")]
        public string InvoiceNumber { get; set; }
        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }
        [JsonProperty("quantity")]
        public int Quantity { get; set; }
        //[JsonProperty("stateid")]
        //public string StateId { get; set; }
        //[JsonProperty("states")]
        //public ICollection<State> States { get; set; }
        //[JsonProperty("local_govId")]
        //public string LocalGovernmentId { get; set; }
        //[JsonProperty("local_gov")]
        //public ICollection<LGA> LocalGovernment { get; set; }
        [JsonProperty("amount")]
        public decimal Amount { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("admin_phone_number")]
        public string AdminPhoneNumber { get; set; }
        [JsonProperty("secret_code")]
        public string SecretCode { get; set; }
    }
}

