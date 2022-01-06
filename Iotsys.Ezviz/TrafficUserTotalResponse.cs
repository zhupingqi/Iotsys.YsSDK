using Newtonsoft.Json;
using System.Collections.Generic;

namespace Iotsys.Ezviz
{
    public class TrafficUserTotalData
    {               
            /// <summary>
            /// 拥有的总流量，单位字节（企业版被赋予带宽能力，不计算该流量）
            /// </summary>
            [JsonProperty("totalFlow")]
            public long TotalFlow { get; set; }
            
            /// <summary>
            /// 已使用的流量，单位字节
            /// </summary>
            [JsonProperty("usedFlow")]
            public long UsedFlow { get; set; }
            
            /// <summary>
            /// 日平均消耗，单位字节/天
            /// </summary>
            [JsonProperty("averageConsume")]
            public long AverageConsume { get; set; }
    }

    public class TrafficUserTotalResponse : ResponseBase<TrafficUserTotalData>
    {
    }
}