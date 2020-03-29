using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Lab09_Manhattan
{
    class Program
    {
        static void Main(string[] args)
        {
            UsingJSON();
        }


        public static void UsingJSON()
        {
            using (StreamReader reader = File.OpenText(@"../../../data.json"))
            {
                JObject manhattan = (JObject)JToken.ReadFrom(new JsonTextReader(reader));

                var newCities =
                from p in manhattan["features"]
                where (string)p["properties"]["neighborhood"] != ""
                select p;

                int count = 0;
                foreach (var item in newCities)
                {
                    count++;
                Console.WriteLine($"{count}: {item}");
                }


            }
        }
    }
}
