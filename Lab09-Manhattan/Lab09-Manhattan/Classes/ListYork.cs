using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab09_Manhattan.Classes
{
    /// <summary>
    /// Root object that will instantiate New York class(features) as an object when its ran.
    /// </summary>
    public class ListYork
    {
        [JsonProperty("features")]
        public List<NewYork> NewYork { get; set; }
    }
}
