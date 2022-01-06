using Newtonsoft.Json;
using System.Collections.Generic;

namespace Iotsys.Ezviz
{
    public class DeviceCaptureData
    {               
            /// <summary>
            /// 抓拍后的图片路径，图片保存有效期为2小时
            /// </summary>
            [JsonProperty("picUrl")]
            public string PicUrl { get; set; }
    }

    public class DeviceCaptureResponse : ResponseBase<DeviceCaptureData>
    {
    }
}