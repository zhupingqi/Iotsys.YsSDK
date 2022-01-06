using Newtonsoft.Json;
using System.Collections.Generic;

namespace Iotsys.Ezviz
{
    public class IntelligenceOcrLicensePlateData
    {               
            /// <summary>
            /// 车牌号
            /// </summary>
            [JsonProperty("number")]
            public string Number { get; set; }
    }

    public class IntelligenceOcrLicensePlateResponse : ResponseBase<IntelligenceOcrLicensePlateData>
    {
    }
}