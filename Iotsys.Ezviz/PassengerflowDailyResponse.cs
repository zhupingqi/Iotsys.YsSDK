using Newtonsoft.Json;
using System.Collections.Generic;

namespace Iotsys.Ezviz
{
    public class PassengerflowDailyData
    {               
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

    public class PassengerflowDailyResponse : ResponseBase<PassengerflowDailyData>
    {
    }
}