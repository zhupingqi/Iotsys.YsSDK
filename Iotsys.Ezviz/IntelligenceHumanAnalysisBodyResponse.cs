using Newtonsoft.Json;
using System.Collections.Generic;

namespace Iotsys.Ezviz
{
    public class IntelligenceHumanAnalysisBodyData
    {               
            /// <summary>
            /// 上衣颜色
            /// </summary>
            [JsonProperty("jacetColor")]
            public string JacetColor { get; set; }
            
            /// <summary>
            /// 是否骑车
            /// </summary>
            [JsonProperty("ride")]
            public string Ride { get; set; }
            
            /// <summary>
            /// 是否带帽
            /// </summary>
            [JsonProperty("hat")]
            public string Hat { get; set; }
            
            /// <summary>
            /// 是否背包
            /// </summary>
            [JsonProperty("bag")]
            public string Bag { get; set; }
            
            /// <summary>
            /// 下装类型
            /// </summary>
            [JsonProperty("trousersType")]
            public Dictionary<string,string> TrousersType { get; set; }
            
            /// <summary>
            /// 下装颜色
            /// </summary>
            [JsonProperty("trousersColor")]
            public Dictionary<string,string> TrousersColor { get; set; }
            
            /// <summary>
            /// 发型
            /// </summary>
            [JsonProperty("hairStyle")]
            public Dictionary<string,string> HairStyle { get; set; }
            
            /// <summary>
            /// 是否拎东西
            /// </summary>
            [JsonProperty("things")]
            public Dictionary<string,string> Things { get; set; }
            
            /// <summary>
            /// 性别
            /// </summary>
            [JsonProperty("gender")]
            public Dictionary<string,string> Gender { get; set; }
            
            /// <summary>
            /// 人体在图片中的坐标
            /// </summary>
            [JsonProperty("rect")]
            public Location Rect { get; set; }
    }

    public class IntelligenceHumanAnalysisBodyResponse : ResponseBase<List<IntelligenceHumanAnalysisBodyData>>
    {
    }
}