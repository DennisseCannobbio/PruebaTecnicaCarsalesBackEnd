using Newtonsoft.Json;

namespace BackendAPI.Infrastructure.Gateway.Model
{
    public class ExternalEpisode
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int Id { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("air_date", NullValueHandling = NullValueHandling.Ignore)]
        public string AirDate { get; set; }

        [JsonProperty("episode", NullValueHandling = NullValueHandling.Ignore)]
        public string Episode { get; set; }

        [JsonProperty("characters", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Characters { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime Created { get; set; }
    }
}
