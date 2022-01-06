using Newtonsoft.Json;
using System.Collections.Generic;

namespace Iotsys.Ezviz
{
    public class CloudStorageServiceOpenInfoData
    {               
            /// <summary>
            /// 是否有开通中的云存储 0:否 1:是
            /// </summary>
            [JsonProperty("isOpening")]
            public int IsOpening { get; set; }
    }

    public class CloudStorageServiceOpenInfoResponse : ResponseBase<CloudStorageServiceOpenInfoData>
    {
    }
}