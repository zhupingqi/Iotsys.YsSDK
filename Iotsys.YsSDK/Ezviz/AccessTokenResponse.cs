using Newtonsoft.Json;

namespace Iotsys.Ezviz
{
    public class AccessTokenResponseData
    {
        [JsonProperty("accessToken")]
        public string AccessToken { get; set; }

        [JsonProperty("expireTime")]
        public long ExpireTime { get; set; }
    }

    public class AccessTokenResponse : ResponseBase<AccessTokenResponseData>
    {
        
    }
}
