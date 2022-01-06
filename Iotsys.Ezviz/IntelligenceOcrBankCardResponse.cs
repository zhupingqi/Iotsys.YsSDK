using Newtonsoft.Json;
using System.Collections.Generic;

namespace Iotsys.Ezviz
{
    public class IntelligenceOcrBankCardData
    {               
            /// <summary>
            /// 每行的文字
            /// </summary>
            [JsonProperty("name")]
            public string Name { get; set; }
            
            /// <summary>
            /// 银行卡号
            /// </summary>
            [JsonProperty("number")]
            public string Number { get; set; }
            
            /// <summary>
            /// 银行卡类型,0: 不能识别; 1: 借记卡; 2: 信用卡
            /// </summary>
            [JsonProperty("type")]
            public int Type { get; set; }
    }

    public class IntelligenceOcrBankCardResponse : ResponseBase<IntelligenceOcrBankCardData>
    {
    }
}