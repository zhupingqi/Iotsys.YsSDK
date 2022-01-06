using Newtonsoft.Json;
using System.Collections.Generic;

namespace Iotsys.Ezviz
{
    public class DeviceWifiQrcodeData
    {               
            /// <summary>
            /// 生成的二维码二进制数据
            /// </summary>
            [JsonProperty("imageData")]
            public string ImageData { get; set; }
    }

    public class DeviceWifiQrcodeResponse : ResponseBase<DeviceWifiQrcodeData>
    {
    }
}