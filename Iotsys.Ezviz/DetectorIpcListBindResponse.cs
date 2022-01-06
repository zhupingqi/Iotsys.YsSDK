using Newtonsoft.Json;
using System.Collections.Generic;

namespace Iotsys.Ezviz
{
    public class DetectorIpcListBindData
    {               
            /// <summary>
            /// 探测器序列号
            /// </summary>
            [JsonProperty("detectorSerial")]
            public string DetectorSerial { get; set; }
            
            /// <summary>
            /// 关联的IPC设备序列号
            /// </summary>
            [JsonProperty("ipcSerial")]
            public string IpcSerial { get; set; }
    }

    public class DetectorIpcListBindResponse : ResponseBase<List<DetectorIpcListBindData>>
    {
    }
}