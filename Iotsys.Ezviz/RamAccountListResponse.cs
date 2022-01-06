using Newtonsoft.Json;
using System.Collections.Generic;

namespace Iotsys.Ezviz
{
    public class RamAccountListData
    {               
            /// <summary>
            /// 子账户信息列表
            /// </summary>
            [JsonProperty("data")]
            public object[] Data { get; set; }
            
            /// <summary>
            /// 操作码
            /// </summary>
            [JsonProperty("code")]
            public string Code { get; set; }
            
            /// <summary>
            /// 操作消息
            /// </summary>
            [JsonProperty("msg")]
            public string Msg { get; set; }
    }

    public class RamAccountListResponse : ResponseBase<List<RamAccountListData>>
    {
            [JsonProperty("page")]
            public ResponsePage Page { get; set; }
    }
}