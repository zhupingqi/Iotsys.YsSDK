using Newtonsoft.Json;
using System.Collections.Generic;

namespace Iotsys.Ezviz
{
    public class CloudStorageDeviceSupportData
    {               
            /// <summary>
            /// 云存储套餐名称
            /// </summary>
            [JsonProperty("cloudProductName")]
            public string CloudProductName { get; set; }
            
            /// <summary>
            /// 云存储类型
            /// </summary>
            [JsonProperty("cloudType")]
            public string CloudType { get; set; }
            
            /// <summary>
            /// 云存储 服务时长
            /// </summary>
            [JsonProperty("serviceTime")]
            public int ServiceTime { get; set; }
            
            /// <summary>
            /// 云存储 服务时间单位 1:天 2:周 3:月 4 年
            /// </summary>
            [JsonProperty("serviceTimeUnit")]
            public int ServiceTimeUnit { get; set; }
            
            /// <summary>
            /// 云存储 存储时长
            /// </summary>
            [JsonProperty("storageTime")]
            public int StorageTime { get; set; }
            
            /// <summary>
            /// 云存储 存储时间单位 1:天 2:周 3:月 4 年
            /// </summary>
            [JsonProperty("storageTimeUnit")]
            public int StorageTimeUnit { get; set; }
            
            /// <summary>
            /// 云存储服务价格 单位 分
            /// </summary>
            [JsonProperty("price")]
            public int Price { get; set; }
            
            /// <summary>
            /// 云存储套餐状态 1:启用 0:停用
            /// </summary>
            [JsonProperty("productStatus")]
            public int ProductStatus { get; set; }
    }

    public class CloudStorageDeviceSupportResponse : ResponseBase<List<CloudStorageDeviceSupportData>>
    {
    }
}