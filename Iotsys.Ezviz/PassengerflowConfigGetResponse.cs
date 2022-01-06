using Newtonsoft.Json;
using System.Collections.Generic;

namespace Iotsys.Ezviz
{
    public class PassengerflowConfigGetData
    {               
            /// <summary>
            /// 统计线的两个坐标点，坐标范围为0到1之间的7位浮点数，(0,0)坐标在左上角，格式如{&quot;x1&quot;: &quot;0.0&quot;,&quot;y1&quot;: &quot;0.5&quot;,&quot;x2&quot;: &quot;1&quot;,&quot;y2&quot;: &quot;0.5&quot;}
            /// </summary>
            [JsonProperty("line")]
            public object Line { get; set; }
            
            /// <summary>
            /// 指示方向的两个坐标点，(x1,y1)为起始点，(x2,y2)为结束点格式如{&quot;x1&quot;: &quot;0.5&quot;,&quot;y1&quot;: &quot;0.5&quot;,&quot;x2&quot;: &quot;0.5&quot;,&quot;y2&quot;: &quot;0.6&quot;}，与统计线保持垂直
            /// </summary>
            [JsonProperty("direction")]
            public object Direction { get; set; }
    }

    public class PassengerflowConfigGetResponse : ResponseBase<PassengerflowConfigGetData>
    {
    }
}