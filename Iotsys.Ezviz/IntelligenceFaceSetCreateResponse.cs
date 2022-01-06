using Newtonsoft.Json;
using System.Collections.Generic;

namespace Iotsys.Ezviz
{
    public class IntelligenceFaceSetCreateData
    {               
            /// <summary>
            /// 人脸集合唯一标识
            /// </summary>
            [JsonProperty("setToken")]
            public string SetToken { get; set; }
    }

    public class IntelligenceFaceSetCreateResponse : ResponseBase<IntelligenceFaceSetCreateData>
    {
    }
}