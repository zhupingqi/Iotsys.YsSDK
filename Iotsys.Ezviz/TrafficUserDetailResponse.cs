using Newtonsoft.Json;
using System.Collections.Generic;

namespace Iotsys.Ezviz
{
    public class TrafficUserDetailData
    {               
            /// <summary>
            /// 日期
            /// </summary>
            [JsonProperty("flowDate")]
            public long FlowDate { get; set; }
            
            /// <summary>
            /// 当日消耗流量设备数
            /// </summary>
            [JsonProperty("deviceCount")]
            public int DeviceCount { get; set; }
            
            /// <summary>
            /// 当日消耗流量通道数
            /// </summary>
            [JsonProperty("channelCount")]
            public int ChannelCount { get; set; }
            
            /// <summary>
            /// 轻应用HLS地址预览消耗，单位字节
            /// </summary>
            [JsonProperty("hlsFlow")]
            public long HlsFlow { get; set; }
            
            /// <summary>
            /// APP应用预览消耗，单位字节
            /// </summary>
            [JsonProperty("appFlow")]
            public long AppFlow { get; set; }
            
            /// <summary>
            /// 轻应用RTMP地址预览消耗，单位字节
            /// </summary>
            [JsonProperty("rtmpFlow")]
            public long RtmpFlow { get; set; }
            
            /// <summary>
            /// 流量消耗汇总，单位字节
            /// </summary>
            [JsonProperty("flowCount")]
            public long FlowCount { get; set; }
    }

    public class TrafficUserDetailResponse : ResponseBase<List<TrafficUserDetailData>>
    {
    }
}