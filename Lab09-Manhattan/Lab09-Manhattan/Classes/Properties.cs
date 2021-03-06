﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab09_Manhattan.Classes
{
    /// <summary>
    /// Properties of what is in Properties object of JSON normalizing it
    /// </summary>
    public class Properties
    {
        public int Zip { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Address { get; set; }
        public string Borough { get; set; }
        public string Neighborhood { get; set; }
        public string County { get; set; }
    }
}
