using Newtonsoft.Json;
using System.Collections.Generic;

namespace Iotsys.Ezviz
{
    public class IntelligenceOcrVehicleLicenseData
    {               
            /// <summary>
            /// 每个字段信息
            /// </summary>
            [JsonProperty("words")]
            public Dictionary<string,string> Words { get; set; }
    }

    public class IntelligenceOcrVehicleLicenseResponse : ResponseBase<IntelligenceOcrVehicleLicenseData>
    {
    }
}