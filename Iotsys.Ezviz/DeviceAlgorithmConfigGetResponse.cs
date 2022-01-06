using Newtonsoft.Json;
using System.Collections.Generic;

namespace Iotsys.Ezviz
{
    public class DeviceAlgorithmConfigGetData
    {               
            /// <summary>
            /// 0表示移动侦测灵敏度
            /// </summary>
            [JsonProperty("type")]
            public string Type { get; set; }
            
            /// <summary>
            /// 通道
            /// </summary>
            [JsonProperty("channel")]
            public string Channel { get; set; }
            
            /// <summary>
            /// type为0时，该值为0~6，0为灵敏度最低
            /// </summary>
            [JsonProperty("value")]
            public int Value { get; set; }
    }

    public class DeviceAlgorithmConfigGetResponse : ResponseBase<List<DeviceAlgorithmConfigGetData>>
    {
    }
}