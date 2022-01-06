using Newtonsoft.Json;
using System.Collections.Generic;

namespace Iotsys.Ezviz
{
    public class DeviceSslSwitchStatusData
    {               
            /// <summary>
            /// 设备序列号,存在英文字母的设备序列号，字母需为大写
            /// </summary>
            [JsonProperty("deviceSerial")]
            public string DeviceSerial { get; set; }
            
            /// <summary>
            /// 通道号
            /// </summary>
            [JsonProperty("channelNo")]
            public int ChannelNo { get; set; }
            
            /// <summary>
            /// 状态：0-关闭，1-开启
            /// </summary>
            [JsonProperty("enable")]
            public int Enable { get; set; }
    }

    public class DeviceSslSwitchStatusResponse : ResponseBase<DeviceSslSwitchStatusData>
    {
    }
}