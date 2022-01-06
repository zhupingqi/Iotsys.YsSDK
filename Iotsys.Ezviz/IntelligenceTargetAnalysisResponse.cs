using Newtonsoft.Json;
using System.Collections.Generic;

namespace Iotsys.Ezviz
{
    public class IntelligenceTargetAnalysisData
    {               
            /// <summary>
            /// 图片高
            /// </summary>
            [JsonProperty("height")]
            public int Height { get; set; }
            
            /// <summary>
            /// 图片宽
            /// </summary>
            [JsonProperty("width")]
            public int Width { get; set; }
            
            /// <summary>
            /// 识别的目标序号
            /// </summary>
            [JsonProperty("ID")]
            public string ID { get; set; }
            
            /// <summary>
            /// 安全帽类型（0-未知，1-合法，2-非法）
            /// </summary>
            [JsonProperty("helmet_type")]
            public int Helmet_type { get; set; }
            
            /// <summary>
            /// 安全帽颜色（1-红，2-黄，3-蓝，4-白，5-其他）
            /// </summary>
            [JsonProperty("color_type")]
            public int Color_type { get; set; }
            
            /// <summary>
            /// 头的坐标
            /// </summary>
            [JsonProperty("head_rect")]
            public Location Head_rect { get; set; }
            
            /// <summary>
            /// 人头的高度,单位px
            /// </summary>
            [JsonProperty("vmodel_h_f")]
            public int Vmodel_h_f { get; set; }
            
            /// <summary>
            /// 人头的宽度,单位px
            /// </summary>
            [JsonProperty("vmodel_w_f")]
            public int Vmodel_w_f { get; set; }
            
            /// <summary>
            /// 人头在图片中左上角的横坐标,单位px
            /// </summary>
            [JsonProperty("vmodel_x_f")]
            public int Vmodel_x_f { get; set; }
            
            /// <summary>
            /// 人头在图片中左上角的纵坐标,单位px
            /// </summary>
            [JsonProperty("vmodel_y_f")]
            public int Vmodel_y_f { get; set; }
            
            /// <summary>
            /// 身体坐标（该字段目前版本无效）
            /// </summary>
            [JsonProperty("body_rect")]
            public Location Body_rect { get; set; }
            
            /// <summary>
            /// 报警标志（该字段目前版本无效）
            /// </summary>
            [JsonProperty("alarm_flg")]
            public int Alarm_flg { get; set; }
            
            /// <summary>
            /// 制服类型（该字段目前版本无效）
            /// </summary>
            [JsonProperty("uniform_type")]
            public int Uniform_type { get; set; }
            
            /// <summary>
            /// 规则信息（无实际含义）
            /// </summary>
            [JsonProperty("rule_info")]
            public string Rule_info { get; set; }
            
            /// <summary>
            /// 规则坐标（无实际含义）
            /// </summary>
            [JsonProperty("rule_list")]
            public Location Rule_list { get; set; }
    }

    public class IntelligenceTargetAnalysisResponse : ResponseBase<List<IntelligenceTargetAnalysisData>>
    {
    }
}