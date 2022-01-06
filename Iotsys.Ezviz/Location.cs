using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Iotsys.Ezviz
{
    public class Location
    {
        [JsonProperty("x")]
        public int X { get; set; }

        [JsonProperty("y")]
        public int Y { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }
    }
}
