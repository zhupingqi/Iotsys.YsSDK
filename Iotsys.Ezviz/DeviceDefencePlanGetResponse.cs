using Newtonsoft.Json;
using System.Collections.Generic;

namespace Iotsys.Ezviz
{
    public class DeviceDefencePlanGetData
    {               
            /// <summary>
            /// 开始时间，如16:00，默认为00:00
            /// </summary>
            [JsonProperty("startTime")]
            public string StartTime { get; set; }
            
            /// <summary>
            /// 结束时间，如16:00，n00:00表示第二天的0点
            /// </summary>
            [JsonProperty("stopTime")]
            public string StopTime { get; set; }
            
            /// <summary>
            /// 周一~周日，用0~6表示，英文逗号分隔
            /// </summary>
            [JsonProperty("period")]
            public string Period { get; set; }
            
            /// <summary>
            /// 是否启用：1-启用，0-不启用
            /// </summary>
            [JsonProperty("enable")]
            public int Enable { get; set; }
    }

    public class DeviceDefencePlanGetResponse : ResponseBase<DeviceDefencePlanGetData>
    {
    }
}