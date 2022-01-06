using Newtonsoft.Json;
using System.Collections.Generic;

namespace Iotsys.Ezviz
{
    public class DeviceListData
    {               
            /// <summary>
            /// 设备序列号,存在英文字母的设备序列号，字母需为大写
            /// </summary>
            [JsonProperty("deviceSerial")]
            public string DeviceSerial { get; set; }
            
            /// <summary>
            /// 设备名称
            /// </summary>
            [JsonProperty("deviceName")]
            public string DeviceName { get; set; }
            
            /// <summary>
            /// 设备类型
            /// </summary>
            [JsonProperty("deviceType")]
            public string DeviceType { get; set; }
            
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
            /// 设备版本号
            /// </summary>
            [JsonProperty("deviceVersion")]
            public int DeviceVersion { get; set; }
    }

    public class DeviceListResponse : ResponseBase<List<DeviceListData>>
    {
            [JsonProperty("page")]
            public ResponsePage Page { get; set; }
    }
}