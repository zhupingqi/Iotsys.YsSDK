using Newtonsoft.Json;
using System.Collections.Generic;

namespace Iotsys.Ezviz
{
    public class VideoByTimeData
    {               
            /// <summary>
            /// 回放源，0-系统自动选择，1-云存储，2-本地录像
            /// </summary>
            [JsonProperty("recType")]
            public int RecType { get; set; }
            
            /// <summary>
            /// 文件开始时间
            /// </summary>
            [JsonProperty("startTime")]
            public long StartTime { get; set; }
            
            /// <summary>
            /// 文件结束时间
            /// </summary>
            [JsonProperty("endTime")]
            public long EndTime { get; set; }
            
            /// <summary>
            /// 设备序列号
            /// </summary>
            [JsonProperty("deviceSerial")]
            public string DeviceSerial { get; set; }
            
            /// <summary>
            /// 设备通道号
            /// </summary>
            [JsonProperty("channelNo")]
            public int ChannelNo { get; set; }
            
            /// <summary>
            /// 文件类型 0:ALARM 1:TIMING 2:IO */
            /// </summary>
            [JsonProperty("localType")]
            public string LocalType { get; set; }
            
            /// <summary>
            /// 该字段已废弃
            /// </summary>
            [JsonProperty("channelType")]
            public string ChannelType { get; set; }
            
            /// <summary>
            /// 云存储信息主键ID
            /// </summary>
            [JsonProperty("id")]
            public long Id { get; set; }
            
            /// <summary>
            /// 文件ID
            /// </summary>
            [JsonProperty("fileId")]
            public string FileId { get; set; }
            
            /// <summary>
            /// 文件所属用户ID
            /// </summary>
            [JsonProperty("ownerId")]
            public string OwnerId { get; set; }
            
            /// <summary>
            /// 文件类型0：目录1：视频文件2：图片文件3：音频文件
            /// </summary>
            [JsonProperty("fileType")]
            public int FileType { get; set; }
            
            /// <summary>
            /// 文件名称
            /// </summary>
            [JsonProperty("fileName")]
            public string FileName { get; set; }
            
            /// <summary>
            /// 该字段已废弃
            /// </summary>
            [JsonProperty("cloudType")]
            public int CloudType { get; set; }
            
            /// <summary>
            /// 文件在云存储上的唯一索引
            /// </summary>
            [JsonProperty("fileIndex")]
            public string FileIndex { get; set; }
            
            /// <summary>
            /// 文件大小，单位B
            /// </summary>
            [JsonProperty("fileSize")]
            public long FileSize { get; set; }
            
            /// <summary>
            /// 是否被锁定。1-锁定；0-未锁定
            /// </summary>
            [JsonProperty("locked")]
            public int Locked { get; set; }
            
            /// <summary>
            /// 创建时间
            /// </summary>
            [JsonProperty("createTime")]
            public long CreateTime { get; set; }
            
            /// <summary>
            /// 是否加密0--不加1--加密
            /// </summary>
            [JsonProperty("crypt")]
            public int Crypt { get; set; }
            
            /// <summary>
            /// 验证码MD5值
            /// </summary>
            [JsonProperty("keyChecksum")]
            public string KeyChecksum { get; set; }
            
            /// <summary>
            /// 录像长度
            /// </summary>
            [JsonProperty("videoLong")]
            public long VideoLong { get; set; }
            
            /// <summary>
            /// 封面图片地址
            /// </summary>
            [JsonProperty("coverPic")]
            public string CoverPic { get; set; }
            
            /// <summary>
            /// 该字段会出现在云存储录像查询中，不可用于下载录像（如需保存录像，可以使用UIkit或SDK中的录制功能）
            /// </summary>
            [JsonProperty("downloadPath")]
            public string DownloadPath { get; set; }
            
            /// <summary>
            /// 该字段已废弃
            /// </summary>
            [JsonProperty("type")]
            public int Type { get; set; }
    }

    public class VideoByTimeResponse : ResponseBase<List<VideoByTimeData>>
    {
    }
}