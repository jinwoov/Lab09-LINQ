﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab09_Manhattan.Classes
{
    /// <summary>
    /// New York class that contains all of the nested information from JSON file and normalizing it according to the syntax that was written in JSON file
    /// </summary>
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
