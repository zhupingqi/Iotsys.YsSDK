using Newtonsoft.Json;
using System.Collections.Generic;

namespace Iotsys.Ezviz
{
    public class DeviceCameraListData
    {               
            /// <summary>
            /// 设备序列号
            /// </summary>
            [JsonProperty("deviceSerial")]
            public string DeviceSerial { get; set; }
            
            /// <summary>
            /// IPC序列号
            /// </summary>
            [JsonProperty("ipcSerial")]
            public string IpcSerial { get; set; }
            
            /// <summary>
            /// 通道号
            /// </summary>
            [JsonProperty("channelNo")]
            public int ChannelNo { get; set; }
            
            /// <summary>
            /// 设备名
            /// </summary>
            [JsonProperty("deviceName")]
            public string DeviceName { get; set; }
            
            /// <summary>
            /// 通道名
            /// </summary>
            [JsonProperty("channelName")]
            public string ChannelName { get; set; }
            
            /// <summary>
            /// 在线状态：0-不在线，1-在线,-1设备未上报（该字段已废弃）
            /// </summary>
            [JsonProperty("status")]
            public int Status { get; set; }
            
            /// <summary>
            /// 图片地址（大图），若在萤石客户端设置封面则返回封面图片，未设置则返回默认图片
            /// </summary>
            [JsonProperty("picUrl")]
            public string PicUrl { get; set; }
            
            /// <summary>
            /// 是否加密，0：不加密，1：加密
            /// </summary>
            [JsonProperty("isEncrypt")]
            public int IsEncrypt { get; set; }
            
            /// <summary>
            /// 视频质量：0-流畅，1-均衡，2-高清，3-超清
            /// </summary>
            [JsonProperty("videoLevel")]
            public int VideoLevel { get; set; }
            
            /// <summary>
            /// 当前通道是否关联IPC：true-是，false-否。设备未上报或者未关联都是false
            /// </summary>
            [JsonProperty("relatedIpc")]
            public bool RelatedIpc { get; set; }
    }

    public class DeviceCameraListResponse : ResponseBase<List<DeviceCameraListData>>
    {
    }
}