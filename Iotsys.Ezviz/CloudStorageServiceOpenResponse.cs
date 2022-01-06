using Newtonsoft.Json;
using System.Collections.Generic;

namespace Iotsys.Ezviz
{
    public class CloudStorageServiceOpenData
    {               
            /// <summary>
            /// 订单ID
            /// </summary>
            [JsonProperty("orderId")]
            public string OrderId { get; set; }
    }

    public class CloudStorageServiceOpenResponse : ResponseBase<CloudStorageServiceOpenData>
    {
    }
}