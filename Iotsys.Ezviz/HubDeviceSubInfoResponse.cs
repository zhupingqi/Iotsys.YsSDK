using Newtonsoft.Json;
using System.Collections.Generic;

namespace Iotsys.Ezviz
{
    public class HubDeviceSubInfoData
    {               
            /// <summary>
            /// 设备名称
            /// </summary>
            [JsonProperty("name")]
            public string Name { get; set; }
            
            /// <summary>
            /// 设备序列号
            /// </summary>
            [JsonProperty("deviceSerial")]
            public string DeviceSerial { get; set; }
            
            /// <summary>
            /// 设备序列号(全)
            /// </summary>
            [JsonProperty("fullSerial")]
            public int FullSerial { get; set; }
            
            /// <summary>
            /// 设备类型
            /// </summary>
            [JsonProperty("deviceType")]
            public string DeviceType { get; set; }
            
            /// <summary>
            /// 设备封面(全路径
            /// </summary>
            [JsonProperty("deviceCoverUrl")]
            public string DeviceCoverUrl { get; set; }
            
            /// <summary>
            /// 设备图片前缀
            /// </summary>
            [JsonProperty("devicePicPrefix")]
            public object DevicePicPrefix { get; set; }
            
            /// <summary>
            /// 版本
            /// </summary>
            [JsonProperty("version")]
            public string Version { get; set; }
            
            /// <summary>
            /// 设备短能力级
            /// </summary>
            [JsonProperty("supportExtShort")]
            public string SupportExtShort { get; set; }
            
            /// <summary>
            /// 设备在线状态，0：初始化，1：在线，2：不在线，4：黑名单，5：待机模式(C1S 电池模式)
            /// </summary>
            [JsonProperty("status")]
            public int Status { get; set; }
            
            /// <summary>
            /// 用户添加设备的时间
            /// </summary>
            [JsonProperty("userDeviceCreateTime")]
            public string UserDeviceCreateTime { get; set; }
            
            /// <summary>
            /// CAS服务器IP
            /// </summary>
            [JsonProperty("casIp")]
            public string CasIp { get; set; }
            
            /// <summary>
            /// CAS服务器Port
            /// </summary>
            [JsonProperty("casPort")]
            public int CasPort { get; set; }
            
            /// <summary>
            /// 设备支持的通道数
            /// </summary>
            [JsonProperty("channelNumber")]
            public int ChannelNumber { get; set; }
            
            /// <summary>
            /// 设备是否需要强制升级,默认false
            /// </summary>
            [JsonProperty("forceUpgrade")]
            public bool ForceUpgrade { get; set; }
            
            /// <summary>
            /// 设备类别
            /// </summary>
            [JsonProperty("category")]
            public string Category { get; set; }
            
            /// <summary>
            /// 是否与当前用户有关联,默认1.0:无关联,1:有关联
            /// </summary>
            [JsonProperty("isRelated")]
            public int IsRelated { get; set; }
            
            /// <summary>
            /// ezDevice能力级,{&#39;sc&#39;:&#39;1&#39;,&#39;v3&#39;:&#39;1&#39;},说明,sc(Single connection) : 是否支持以设备为单位建立连接，1：支持，0：不支持；v3:是否支持p2p的v3版本，1：支持，0：不支持
            /// </summary>
            [JsonProperty("ezDeviceCapability")]
            public string EzDeviceCapability { get; set; }
            
            /// <summary>
            /// 设备自定义类型
            /// </summary>
            [JsonProperty("customType")]
            public string CustomType { get; set; }
            
            /// <summary>
            /// 设备拥有者用户id
            /// </summary>
            [JsonProperty("userId")]
            public string UserId { get; set; }
            
            /// <summary>
            /// 设备离线时间
            /// </summary>
            [JsonProperty("offlineTime")]
            public string OfflineTime { get; set; }
            
            /// <summary>
            /// 0-支持分组,1-不支持分组
            /// </summary>
            [JsonProperty("isGroupDisable")]
            public int IsGroupDisable { get; set; }
            
            /// <summary>
            /// 子设备布撤防计划
            /// </summary>
            [JsonProperty("detectorDefencePlanVo")]
            public object DetectorDefencePlanVo { get; set; }
    }

    public class HubDeviceSubInfoResponse : ResponseBase<HubDeviceSubInfoData>
    {
    }
}