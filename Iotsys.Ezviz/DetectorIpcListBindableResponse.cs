using Newtonsoft.Json;
using System.Collections.Generic;

namespace Iotsys.Ezviz
{
    public class DetectorIpcListBindableData
    {               
            /// <summary>
            /// IPC的设备序列号
            /// </summary>
            [JsonProperty("deviceSerial")]
            public string DeviceSerial { get; set; }
            
            /// <summary>
            /// 通道号
            /// </summary>
            [JsonProperty("channelNo")]
            public int ChannelNo { get; set; }
            
            /// <summary>
            /// IPC的名称
            /// </summary>
            [JsonProperty("cameraName")]
            public int CameraName { get; set; }
    }

    public class DetectorIpcListBindableResponse : ResponseBase<List<DetectorIpcListBindableData>>
    {
    }
}