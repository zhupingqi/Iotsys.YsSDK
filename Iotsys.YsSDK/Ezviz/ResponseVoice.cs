using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Iotsys.Ezviz
{
    public class ResponseVoice
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
