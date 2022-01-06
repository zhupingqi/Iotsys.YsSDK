using Newtonsoft.Json;

namespace Iotsys.Ezviz
{
    public class ResponsePage
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }
    }
}
