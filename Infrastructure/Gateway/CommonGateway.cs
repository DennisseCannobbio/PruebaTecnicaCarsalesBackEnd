using DIExample.Domain.Exceptions;
using Newtonsoft.Json;
using System.Net.Http;

namespace DIExample.Infrastructure.Gateway
{
    public static class CommonGateway<T>
    {
        public static T GetFromGateway(string url)
        {
            HttpClient client = new();

            var response = client.GetAsync(url).Result;

            response.EnsureSuccessStatusCode();

            var result = response.Content.ReadAsStringAsync().Result;

            return JsonConvert.DeserializeObject<T>(result);
        }

        public static List<T> GetFromGatewayLst(string url)
        {
            HttpClient client = new();

            var response = client.GetAsync(url).Result;

            response.EnsureSuccessStatusCode();

            var result = response.Content.ReadAsStringAsync().Result;

            var res = JsonConvert.DeserializeObject<Root<T>>(result);

            return res.Results;
        }

        public class Root<T>
        {
            [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
            public int Count { get; set; }

            [JsonProperty("pages", NullValueHandling = NullValueHandling.Ignore)]
            public int Pages { get; set; }

            [JsonProperty("next", NullValueHandling = NullValueHandling.Ignore)]
            public string Next { get; set; }

            [JsonProperty("prev", NullValueHandling = NullValueHandling.Ignore)]
            public object Prev { get; set; }

            [JsonProperty("results")]
            public List<T> Results { get; set; }
        }
    }
}
