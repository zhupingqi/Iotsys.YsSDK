using Newtonsoft.Json;
using System.Collections.Generic;

namespace Iotsys.Ezviz
{
    public class CloudV2StorageDeviceInfoData
    {               
            /// <summary>
            /// 设备序列号
            /// </summary>
            [JsonProperty("deviceSerial")]
            public string DeviceSerial { get; set; }
            
            /// <summary>
            /// 用户名
            /// </summary>
            [JsonProperty("username")]
            public string Username { get; set; }
            
            /// <summary>
            /// 设备通道号
            /// </summary>
            [JsonProperty("channelNo")]
            public int ChannelNo { get; set; }
            
            /// <summary>
            /// 存储时长
            /// </summary>
            [JsonProperty("totalDays")]
            public int TotalDays { get; set; }
            
            /// <summary>
            /// 当前云存储服务状态 1:开启  0:暂停
            /// </summary>
            [JsonProperty("userEnable")]
            public int UserEnable { get; set; }
            
            /// <summary>
            /// 当前云存储的服务时长
            /// </summary>
            [JsonProperty("serviceTime")]
            public int ServiceTime { get; set; }
            
            /// <summary>
            /// 当前云存储的服务时间单位 1:天 2:周 3:月 4:年
            /// </summary>
            [JsonProperty("serviceTimeUnit")]
            public int ServiceTimeUnit { get; set; }
            
            /// <summary>
            /// 当前云存储的存储时长
            /// </summary>
            [JsonProperty("storageTime")]
            public int StorageTime { get; set; }
            
            /// <summary>
            /// 当前云存储的存储时间单位 1:天 2:周 3:月 4:年
            /// </summary>
            [JsonProperty("storageTimeUnit")]
            public int StorageTimeUnit { get; set; }
            
            /// <summary>
            /// 云存储服务对象 ,包含所有可用的云存储
            /// </summary>
            [JsonProperty("cloudStorageServiceRespList")]
            public object[] CloudStorageServiceRespList { get; set; }
            
            /// <summary>
            /// 订单号
            /// </summary>
            [JsonProperty("bussinessOrderId")]
            public int BussinessOrderId { get; set; }
            
            /// <summary>
            /// 产品付费类型 1:付费 2:试用 3：其他
            /// </summary>
            [JsonProperty("productPayType")]
            public int ProductPayType { get; set; }
            
            /// <summary>
            /// 生效时间,时间戳
            /// </summary>
            [JsonProperty("effectTime")]
            public long EffectTime { get; set; }
            
            /// <summary>
            /// 过期时间,时间戳
            /// </summary>
            [JsonProperty("expireTime")]
            public long ExpireTime { get; set; }
            
            /// <summary>
            /// 云存储状态 1:待使用 2:使用中
            /// </summary>
            [JsonProperty("status")]
            public int Status { get; set; }
            
            /// <summary>
            /// 用户激活状态 1:激活状态 2:暂停状态
            /// </summary>
            [JsonProperty("userActiveStatus")]
            public int UserActiveStatus { get; set; }
            
            /// <summary>
            /// 服务是否立即生效 1:立即生效  2:延迟生效
            /// </summary>
            [JsonProperty("effectImmediately")]
            public int EffectImmediately { get; set; }
    }

    public class CloudV2StorageDeviceInfoResponse : ResponseBase<List<CloudV2StorageDeviceInfoData>>
    {
    }
}