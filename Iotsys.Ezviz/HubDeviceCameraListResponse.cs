using Newtonsoft.Json;
using System.Collections.Generic;

namespace Iotsys.Ezviz
{
    public class HubDeviceCameraListData
    {               
            /// <summary>
            /// 子设备序列号
            /// </summary>
            [JsonProperty("deviceSerial")]
            public string DeviceSerial { get; set; }
            
            /// <summary>
            /// 通道号
            /// </summary>
            [JsonProperty("channelNo")]
            public int ChannelNo { get; set; }
            
            /// <summary>
            /// 通道名称
            /// </summary>
            [JsonProperty("channelName")]
            public int ChannelName { get; set; }
            
            /// <summary>
            /// 通道类型
            /// </summary>
            [JsonProperty("channelType")]
            public string ChannelType { get; set; }
            
            /// <summary>
            /// 联通状态
            /// </summary>
            [JsonProperty("connectStatus")]
            public string ConnectStatus { get; set; }
            
            /// <summary>
            /// 通道封面
            /// </summary>
            [JsonProperty("picPath")]
            public string PicPath { get; set; }
            
            /// <summary>
            /// 视频清晰度
            /// </summary>
            [JsonProperty("videoLevel")]
            public int VideoLevel { get; set; }
    }

    public class HubDeviceCameraListResponse : ResponseBase<List<HubDeviceCameraListData>>
    {
    }
}