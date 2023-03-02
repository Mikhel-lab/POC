using Newtonsoft.Json;
using POC.Models.StateEntity;

namespace POC.Models.LGAEntity
{
    public class LGA
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("lga")]
        public string lga { get; set; }
    }



}

