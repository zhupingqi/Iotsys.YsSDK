using Newtonsoft.Json;
using System.Collections.Generic;

namespace Iotsys.Ezviz
{
    public class IntelligenceOcrIdCardData
    {               
            /// <summary>
            /// 每个字段对应的坐标信息(注:如果没有检测出文字则为空)
            /// </summary>
            [JsonProperty("locations")]
            public Dictionary<string,Location> Locations { get; set; }
            
            /// <summary>
            /// 每个字段信息
            /// </summary>
            [JsonProperty("words")]
            public Dictionary<string,string> Words { get; set; }
    }

    public class IntelligenceOcrIdCardResponse : ResponseBase<IntelligenceOcrIdCardData>
    {
    }
}