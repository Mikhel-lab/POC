using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace POC.Models.StateEntity
{
    public class State
    {
        [Key]
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string name { get; set; }
    }
}
