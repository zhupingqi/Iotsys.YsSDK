using Newtonsoft.Json;
using System.Collections.Generic;

namespace Iotsys.Ezviz
{
    public class DevicePresetAddData
    {               
            /// <summary>
            /// 预置点序号，C6设备是1-12，该参数需要开发者自行保存
            /// </summary>
            [JsonProperty("index")]
            public int Index { get; set; }
    }

    public class DevicePresetAddResponse : ResponseBase<DevicePresetAddData>
    {
    }
}