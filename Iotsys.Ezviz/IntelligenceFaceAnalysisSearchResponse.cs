using Newtonsoft.Json;
using System.Collections.Generic;

namespace Iotsys.Ezviz
{
    public class IntelligenceFaceAnalysisSearchData
    {               
            /// <summary>
            /// 检索出匹配的人脸列表信息,如果没有匹配则为空数组
            /// </summary>
            [JsonProperty("results")]
            public object[] Results { get; set; }
            
            /// <summary>
            /// 人脸唯一标识
            /// </summary>
            [JsonProperty("faceToken")]
            public string FaceToken { get; set; }
            
            /// <summary>
            /// 匹配得分
            /// </summary>
            [JsonProperty("score")]
            public double Score { get; set; }
    }

    public class IntelligenceFaceAnalysisSearchResponse : ResponseBase<IntelligenceFaceAnalysisSearchData>
    {
    }
}