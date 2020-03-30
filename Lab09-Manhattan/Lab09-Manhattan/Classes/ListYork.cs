using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab09_Manhattan.Classes
{
    public class ListYork
    {
        [JsonProperty("features")]
        public List<NewYork> NewYork { get; set; }
    }
}
