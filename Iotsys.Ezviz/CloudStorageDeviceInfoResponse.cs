using Newtonsoft.Json;
using System.Collections.Generic;

namespace Iotsys.Ezviz
{
    public class CloudStorageDeviceInfoData
    {               
            /// <summary>
            /// 云存储服务所属用户的用户名
            /// </summary>
            [JsonProperty("userName")]
            public string UserName { get; set; }
            
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
            /// 云存储服务录像覆盖周期
            /// </summary>
            [JsonProperty("totalDays")]
            public int TotalDays { get; set; }
            
            /// <summary>
            /// 云存储状态，-2:设备不支持，-1:未开通云存储，0:未激活，1:激活，2:过期
            /// </summary>
            [JsonProperty("status")]
            public int Status { get; set; }
            
            /// <summary>
            /// 可用天数
            /// </summary>
            [JsonProperty("validDays")]
            public int ValidDays { get; set; }
            
            /// <summary>
            /// 云存储服务开始时间，精确到秒
            /// </summary>
            [JsonProperty("startTime")]
            public long StartTime { get; set; }
            
            /// <summary>
            /// 云存储服务结束时间，精确到秒
            /// </summary>
            [JsonProperty("expireTime")]
            public long ExpireTime { get; set; }
            
            /// <summary>
            /// 不同类型云存储服务信息，只有当设备存在两种类型云存储服务才会有此对象
            /// </summary>
            [JsonProperty("serviceDetail")]
            public object ServiceDetail { get; set; }
    }

    public class CloudStorageDeviceInfoResponse : ResponseBase<CloudStorageDeviceInfoData>
    {
    }
}