using Newtonsoft.Json;
using System.Collections.Generic;

namespace Iotsys.Ezviz
{
    public class IntelligenceHumanAnalysisDetectData
    {               
            /// <summary>
            /// 是否有人: true-有人, false-无人
            /// </summary>
            [JsonProperty("exists")]
            public bool Exists { get; set; }
            
            /// <summary>
            /// 检测出的具体人数
            /// </summary>
            [JsonProperty("number")]
            public int Number { get; set; }
            
            /// <summary>
            /// 检测出的人形列表,如果没有检测出人形则为空数组
            /// </summary>
            [JsonProperty("locations")]
            public object[] Locations { get; set; }
    }

    public class IntelligenceHumanAnalysisDetectResponse : ResponseBase<IntelligenceHumanAnalysisDetectData>
    {
    }
}