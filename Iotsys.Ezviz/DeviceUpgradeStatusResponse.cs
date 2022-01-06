using Newtonsoft.Json;
using System.Collections.Generic;

namespace Iotsys.Ezviz
{
    public class DeviceUpgradeStatusData
    {               
            /// <summary>
            /// 升级进度，仅status为正在升级状态时有效，取值范围为1-100
            /// </summary>
            [JsonProperty("progress")]
            public int Progress { get; set; }
            
            /// <summary>
            /// 升级状态： 0-正在升级，1-设备重启，2-升级成功，大于2-升级失败
            /// </summary>
            [JsonProperty("status")]
            public int Status { get; set; }
    }

    public class DeviceUpgradeStatusResponse : ResponseBase<DeviceUpgradeStatusData>
    {
    }
}