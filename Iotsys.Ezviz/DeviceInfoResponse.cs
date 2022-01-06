using Newtonsoft.Json;
using System.Collections.Generic;

namespace Iotsys.Ezviz
{
    public class DeviceInfoData
    {               
            /// <summary>
            /// 设备序列号
            /// </summary>
            [JsonProperty("deviceSerial")]
            public string DeviceSerial { get; set; }
            
            /// <summary>
            /// 设备名称
            /// </summary>
            [JsonProperty("deviceName")]
            public string DeviceName { get; set; }
            
            /// <summary>
            /// 设备型号，如CS-C2S-21WPFR-WX
            /// </summary>
            [JsonProperty("model")]
            public string Model { get; set; }
            
            /// <summary>
            /// 在线状态：0-不在线，1-在线
            /// </summary>
            [JsonProperty("status")]
            public int Status { get; set; }
            
            /// <summary>
            /// 具有防护能力的设备布撤防状态：0-睡眠，8-在家，16-外出，普通IPC布撤防状态：0-撤防，1-布防
            /// </summary>
            [JsonProperty("defence")]
            public int Defence { get; set; }
            
            /// <summary>
            /// 是否加密：0-不加密，1-加密
            /// </summary>
            [JsonProperty("isEncrypt")]
            public int IsEncrypt { get; set; }
            
            /// <summary>
            /// 告警声音模式：0-短叫，1-长叫，2-静音
            /// </summary>
            [JsonProperty("alarmSoundMode")]
            public int AlarmSoundMode { get; set; }
            
            /// <summary>
            /// 设备下线是否通知：0-不通知 1-通知
            /// </summary>
            [JsonProperty("offlineNotify")]
            public int OfflineNotify { get; set; }
            
            /// <summary>
            /// 设备大类
            /// </summary>
            [JsonProperty("category")]
            public string Category { get; set; }
            
            /// <summary>
            /// 网络类型，如有线连接wire
            /// </summary>
            [JsonProperty("netType")]
            public string NetType { get; set; }
            
            /// <summary>
            /// 信号强度(%)
            /// </summary>
            [JsonProperty("signal")]
            public string Signal { get; set; }
    }

    public class DeviceInfoResponse : ResponseBase<DeviceInfoData>
    {
    }
}