using Newtonsoft.Json;
using System.Collections.Generic;

namespace Iotsys.Ezviz
{
    public class CloudStorageTrialData
    {               
            /// <summary>
            /// 订单号
            /// </summary>
            [JsonProperty("orderId")]
            public string OrderId { get; set; }
    }

    public class CloudStorageTrialResponse : ResponseBase<CloudStorageTrialData>
    {
    }
}