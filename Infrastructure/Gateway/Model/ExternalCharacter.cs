using Newtonsoft.Json;

namespace BackendAPI.Infrastructure.Gateway.Model
{
    public class ExternalCharacter
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
        public string Url { get; set; }
    }
}
