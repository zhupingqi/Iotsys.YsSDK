using Newtonsoft.Json;
using System.Collections.Generic;

namespace Iotsys.Ezviz
{
    public class IntelligenceOcrDriverLicenseData
    {               
            /// <summary>
            /// 每个字段信息
            /// </summary>
            [JsonProperty("words")]
            public Dictionary<string,string> Words { get; set; }
    }

    public class IntelligenceOcrDriverLicenseResponse : ResponseBase<IntelligenceOcrDriverLicenseData>
    {
    }
}