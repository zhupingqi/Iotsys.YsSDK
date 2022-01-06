using Newtonsoft.Json;
using System.Collections.Generic;

namespace Iotsys.Ezviz
{
    public class IntelligenceVehicleAnalysisTrafficData
    {               
            /// <summary>
            /// 驾驶员安全带
            /// </summary>
            [JsonProperty("majorSafeBelt")]
            public string MajorSafeBelt { get; set; }
            
            /// <summary>
            /// 副驾驶安全带
            /// </summary>
            [JsonProperty("viceSafeBelt")]
            public string ViceSafeBelt { get; set; }
            
            /// <summary>
            /// 主驾驶遮阳板
            /// </summary>
            [JsonProperty("majorSunVisor")]
            public string MajorSunVisor { get; set; }
            
            /// <summary>
            /// 副驾驶遮阳板
            /// </summary>
            [JsonProperty("viceSunVisor")]
            public string ViceSunVisor { get; set; }
            
            /// <summary>
            /// 危险品标志
            /// </summary>
            [JsonProperty("dangeMark")]
            public string DangeMark { get; set; }
            
            /// <summary>
            /// 黄标车
            /// </summary>
            [JsonProperty("yellowLabel")]
            public string YellowLabel { get; set; }
            
            /// <summary>
            /// 打电话
            /// </summary>
            [JsonProperty("phoning")]
            public string Phoning { get; set; }
            
            /// <summary>
            /// 挂件
            /// </summary>
            [JsonProperty("pendant")]
            public string Pendant { get; set; }
            
            /// <summary>
            /// 车辆在图片中的坐标
            /// </summary>
            [JsonProperty("rect")]
            public Location Rect { get; set; }
    }

    public class IntelligenceVehicleAnalysisTrafficResponse : ResponseBase<List<IntelligenceVehicleAnalysisTrafficData>>
    {
    }
}