using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace POC.Models.FactoryEntity
{
    public class FactoryLocation
    {
        [Key]
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("factoryLocation")]
        public string factoryLocation { get; set; }
        
    }
}



