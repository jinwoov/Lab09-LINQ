using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab09_Manhattan.Classes
{
    public class NewYork
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("geometry")]
        public Geometry Geometry { get; set; }

        [JsonProperty("properties")]
        public Properties Properties { get; set; }


    }
}
