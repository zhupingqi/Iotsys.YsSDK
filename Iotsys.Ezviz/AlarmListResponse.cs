using Newtonsoft.Json;
using System.Collections.Generic;

namespace Iotsys.Ezviz
{
    public class AlarmListData
    {               
            /// <summary>
            /// 消息ID
            /// </summary>
            [JsonProperty("alarmId")]
            public string AlarmId { get; set; }
            
            /// <summary>
            /// 告警源名称
            /// </summary>
            [JsonProperty("alarmName")]
            public string AlarmName { get; set; }
            
            /// <summary>
            /// 告警类型
            /// </summary>
            [JsonProperty("alarmType")]
            public int AlarmType { get; set; }
            
            /// <summary>
            /// 告警时间，long格式如12323452345，精确到毫秒
            /// </summary>
            [JsonProperty("alarmTime")]
            public long AlarmTime { get; set; }
            
            /// <summary>
            /// 通道号
            /// </summary>
            [JsonProperty("channelNo")]
            public int ChannelNo { get; set; }
            
            /// <summary>
            /// 是否加密：0-不加密，1-加密
            /// </summary>
            [JsonProperty("isEncrypt")]
            public int IsEncrypt { get; set; }
            
            /// <summary>
            /// 是否已读：0-未读，1-已读
            /// </summary>
            [JsonProperty("isChecked")]
            public int IsChecked { get; set; }
            
            /// <summary>
            /// 存储类型：0-无存储，1-萤石云存储，4-sd卡存储，5-萤石云存储和sd卡存储
            /// </summary>
            [JsonProperty("recState")]
            public int RecState { get; set; }
            
            /// <summary>
            /// 预录时间：单位秒
            /// </summary>
            [JsonProperty("preTime")]
            public int PreTime { get; set; }
            
            /// <summary>
            /// 延迟录像时间：单位秒
            /// </summary>
            [JsonProperty("delayTime")]
            public int DelayTime { get; set; }
            
            /// <summary>
            /// 设备序列号
            /// </summary>
            [JsonProperty("deviceSerial")]
            public string DeviceSerial { get; set; }
            
            /// <summary>
            /// 告警图片地址
            /// </summary>
            [JsonProperty("alarmPicUrl")]
            public string AlarmPicUrl { get; set; }
            
            /// <summary>
            /// 关联的告警消息
            /// </summary>
            [JsonProperty("relationAlarms")]
            public object[] RelationAlarms { get; set; }
            
            /// <summary>
            /// 透传设备参数类型
            /// </summary>
            [JsonProperty("customerType")]
            public string CustomerType { get; set; }
            
            /// <summary>
            /// 透传设备参数内容
            /// </summary>
            [JsonProperty("customerInfo")]
            public string CustomerInfo { get; set; }
    }

    public class AlarmListResponse : ResponseBase<List<AlarmListData>>
    {
            [JsonProperty("page")]
            public ResponsePage Page { get; set; }
    }
}