using Newtonsoft.Json;
using System.Collections.Generic;

namespace Iotsys.Ezviz
{
    public class V2LiveAddressGetData
    {               
            /// <summary>
            /// 状态码，参考下方返回码。优先判断该错误码，返回200即表示成功。
            /// </summary>
            [JsonProperty("code")]
            public string Code { get; set; }
            
            /// <summary>
            /// 状态描述
            /// </summary>
            [JsonProperty("msg")]
            public string Msg { get; set; }
            
            /// <summary>
            /// 状态描述
            /// </summary>
            [JsonProperty("id")]
            public string Id { get; set; }
            
            /// <summary>
            /// 直播地址
            /// </summary>
            [JsonProperty("url")]
            public string Url { get; set; }
            
            /// <summary>
            /// 直播地址有效期。expireTime参数为空时该字段无效
            /// </summary>
            [JsonProperty("expireTime")]
            public long ExpireTime { get; set; }
    }

    public class V2LiveAddressGetResponse : ResponseBase<V2LiveAddressGetData>
    {
    }
}