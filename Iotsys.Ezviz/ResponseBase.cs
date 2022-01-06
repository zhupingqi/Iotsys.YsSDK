using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Iotsys.Ezviz
{
    public class ResponseBase
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("msg")]
        public string Msg { get; set; }
    }

    public class ResponseBase<T>:ResponseBase
    {
        [JsonProperty("data")]
        public T Data { get; set; }
    }
}
