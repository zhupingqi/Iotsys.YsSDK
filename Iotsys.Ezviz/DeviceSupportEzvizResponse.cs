using Newtonsoft.Json;
using System.Collections.Generic;

namespace Iotsys.Ezviz
{
    public class DeviceSupportEzvizData
    {               
            /// <summary>
            /// 设备型号
            /// </summary>
            [JsonProperty("model")]
            public string Model { get; set; }
            
            /// <summary>
            /// 设备版本号,当 isSupport=0时,返回最近支持的版本,当isSupport=1时,返回当前版本
            /// </summary>
            [JsonProperty("version")]
            public string Version { get; set; }
            
            /// <summary>
            /// 是否支持萤石协议, 0:不支持, 1:支持
            /// </summary>
            [JsonProperty("isSupport")]
            public int IsSupport { get; set; }
    }

    public class DeviceSupportEzvizResponse : ResponseBase<List<DeviceSupportEzvizData>>
    {
    }
}