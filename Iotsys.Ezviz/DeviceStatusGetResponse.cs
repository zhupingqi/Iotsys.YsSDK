using Newtonsoft.Json;
using System.Collections.Generic;

namespace Iotsys.Ezviz
{
    public class DeviceStatusGetData
    {               
            /// <summary>
            /// 隐私状态: 0：隐私状态关闭；1：隐私状态打开；-1：初始值；2：不支持,C1专用,-2:设备没有上报或者设备不支持该状态
            /// </summary>
            [JsonProperty("privacyStatus")]
            public int PrivacyStatus { get; set; }
            
            /// <summary>
            /// 红外状态，1：红外启用，0：红外禁用，-1：初始值，2：不支持,-2:设备没有上报或者设备不支持该状态
            /// </summary>
            [JsonProperty("pirStatus")]
            public int PirStatus { get; set; }
            
            /// <summary>
            /// 告警声音模式，0：短叫，1：长叫，2：静音,3:自定义语音,-1:设备没有上报或者设备不支持该状态
            /// </summary>
            [JsonProperty("alarmSoundMode")]
            public int AlarmSoundMode { get; set; }
            
            /// <summary>
            /// 电池电量,1到100(%)，-1:设备没有上报或者设备不支持该状态
            /// </summary>
            [JsonProperty("battryStatus")]
            public int BattryStatus { get; set; }
            
            /// <summary>
            /// 门锁和网关间的无线信号，百分比表示 差值超过10上报,-1:设备没有上报或者设备不支持该状态
            /// </summary>
            [JsonProperty("lockSignal")]
            public int LockSignal { get; set; }
            
            /// <summary>
            /// 挂载的sd硬盘数量,-1:设备没有上报或者设备不支持该状态
            /// </summary>
            [JsonProperty("diskNum")]
            public int DiskNum { get; set; }
            
            /// <summary>
            /// sd硬盘状态:0:正常;1:存储介质错;2:未格式化;3:正在格式化;返回形式:一个硬盘表示为&quot;0---------------&quot;,两个硬盘表示为&quot;00--------------&quot;,以此类推;-1:设备没有上报或者设备不支持该状态
            /// </summary>
            [JsonProperty("diskState")]
            public string DiskState { get; set; }
            
            /// <summary>
            /// 云存储状态: -2:设备不支持;-1: 未开通;0: 未激活;1: 激活;2: 过期
            /// </summary>
            [JsonProperty("cloudStatus")]
            public int CloudStatus { get; set; }
            
            /// <summary>
            /// NVR上挂载的硬盘数量: -1:设备没有上报或者设备不支持;-2:未关联,类似于NVR类型的上级设备
            /// </summary>
            [JsonProperty("nvrDiskNum")]
            public int NvrDiskNum { get; set; }
            
            /// <summary>
            /// NVR上挂载的硬盘状态:0:正常;1:存储介质错;2:未格式化;3:正在格式化;返回形式:一个硬盘表示为&quot;0---------------&quot;,两个硬盘表示为&quot;00--------------&quot;,以此类推;-1:设备没有上报或者设备不支持该状态;-2:未关联,类似于NVR类型的上级设备
            /// </summary>
            [JsonProperty("nvrDiskState")]
            public string NvrDiskState { get; set; }
    }

    public class DeviceStatusGetResponse : ResponseBase<DeviceStatusGetData>
    {
    }
}