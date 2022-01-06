using Newtonsoft.Json;
using System.Collections.Generic;

namespace Iotsys.Ezviz
{
    public class PassengerflowHourlyData
    {               
            /// <summary>
            /// 小时索引
            /// </summary>
            [JsonProperty("hourIndex")]
            public int HourIndex { get; set; }
            
            /// <summary>
            /// 进店流量
            /// </summary>
            [JsonProperty("inFlow")]
            public int InFlow { get; set; }
            
            /// <summary>
            /// 出店流量
            /// </summary>
            [JsonProperty("outFlow")]
            public int OutFlow { get; set; }
    }

    public class PassengerflowHourlyResponse : ResponseBase<List<PassengerflowHourlyData>>
    {
    }
}