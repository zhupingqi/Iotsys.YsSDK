using Newtonsoft.Json;
using System.Collections.Generic;

namespace Iotsys.Ezviz
{
    public class DeviceVersionInfoData
    {               
            /// <summary>
            /// 最新版本
            /// </summary>
            [JsonProperty("latestVersion")]
            public string LatestVersion { get; set; }
            
            /// <summary>
            /// 当前版本
            /// </summary>
            [JsonProperty("currentVersion")]
            public string CurrentVersion { get; set; }
            
            /// <summary>
            /// 是否需要升级：0-不需要，1-需要
            /// </summary>
            [JsonProperty("isNeedUpgrade")]
            public int IsNeedUpgrade { get; set; }
            
            /// <summary>
            /// 是否正在升级 0-未升级, 1-正在升级
            /// </summary>
            [JsonProperty("isUpgrading")]
            public int IsUpgrading { get; set; }
    }

    public class DeviceVersionInfoResponse : ResponseBase<DeviceVersionInfoData>
    {
    }
}