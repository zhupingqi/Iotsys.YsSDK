using Newtonsoft.Json;
using System.Collections.Generic;

namespace Iotsys.Ezviz
{
    public class HubDeviceSubListData
    {               
            /// <summary>
            /// 子设备序列号
            /// </summary>
            [JsonProperty("deviceSerial")]
            public string DeviceSerial { get; set; }
            
            /// <summary>
            /// 子设备名称
            /// </summary>
            [JsonProperty("deviceName")]
            public string DeviceName { get; set; }
            
            /// <summary>
            /// 子设备类型 ：1-探测器 2-开关
            /// </summary>
            [JsonProperty("type")]
            public int Type { get; set; }
            
            /// <summary>
            /// 设备封面(全路径)
            /// </summary>
            [JsonProperty("deviceCoverUrl")]
            public string DeviceCoverUrl { get; set; }
            
            /// <summary>
            /// 设备类型
            /// </summary>
            [JsonProperty("deviceType")]
            public string DeviceType { get; set; }
            
            /// <summary>
            /// 子设备状态
            /// </summary>
            [JsonProperty("subDeviceStatusVos")]
            public object SubDeviceStatusVos { get; set; }
    }

    public class HubDeviceSubListResponse : ResponseBase<List<HubDeviceSubListData>>
    {
    }
}