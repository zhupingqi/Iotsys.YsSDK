using Newtonsoft.Json;
using System.Collections.Generic;

namespace Iotsys.Ezviz
{
    public class RamAccountGetData
    {               
            /// <summary>
            /// 子账户Id
            /// </summary>
            [JsonProperty("accountId")]
            public string AccountId { get; set; }
            
            /// <summary>
            /// 子账户名
            /// </summary>
            [JsonProperty("accountName")]
            public string AccountName { get; set; }
            
            /// <summary>
            /// 子账户所属应用的AppKey
            /// </summary>
            [JsonProperty("appKey")]
            public string AppKey { get; set; }
            
            /// <summary>
            /// 子账户状态，0为停用，1为启用
            /// </summary>
            [JsonProperty("accountStatus")]
            public int AccountStatus { get; set; }
            
            /// <summary>
            /// 子账户的授权策略
            /// </summary>
            [JsonProperty("policy")]
            public object Policy { get; set; }
    }

    public class RamAccountGetResponse : ResponseBase<RamAccountGetData>
    {
    }
}