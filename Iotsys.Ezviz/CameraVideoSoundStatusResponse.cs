using Newtonsoft.Json;
using System.Collections.Generic;

namespace Iotsys.Ezviz
{
    public class CameraVideoSoundStatusData
    {               
            /// <summary>
            /// 设备序列号,存在英文字母的设备序列号，字母需为大写
            /// </summary>
            [JsonProperty("deviceSerial")]
            public string DeviceSerial { get; set; }
            
            /// <summary>
            /// 设备通道号
            /// </summary>
            [JsonProperty("channelNo")]
            public int ChannelNo { get; set; }
            
            /// <summary>
            /// 麦克风开关标识:0:关闭;1:打开
            /// </summary>
            [JsonProperty("enable")]
            public string Enable { get; set; }
    }

    public class CameraVideoSoundStatusResponse : ResponseBase<List<CameraVideoSoundStatusData>>
    {
    }
}