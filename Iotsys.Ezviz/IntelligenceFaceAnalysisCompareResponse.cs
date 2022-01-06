using Newtonsoft.Json;
using System.Collections.Generic;

namespace Iotsys.Ezviz
{
    public class IntelligenceFaceAnalysisCompareData
    {               
            /// <summary>
            /// 比对得分,介于 0~1 之间,越大标识两张图片相似度越高
            /// </summary>
            [JsonProperty("score")]
            public double Score { get; set; }
    }

    public class IntelligenceFaceAnalysisCompareResponse : ResponseBase<IntelligenceFaceAnalysisCompareData>
    {
    }
}