using System;
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

                foreach (var item in manhattan)
                {
                    Console.WriteLine(item);
                }

                var neighbor = manh


            }
        }
    }
}
