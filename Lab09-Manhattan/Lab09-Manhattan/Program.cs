using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Lab09_Manhattan.Classes;
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

                //var serializer = new JsonSerializer();
                //serializer.Deserialize(reader);
                //JObject manhattan = (JObject)JToken.ReadFrom(new JsonTextReader(reader));

            
                var par = reader.ReadToEnd();

                var parseData = JsonConvert.DeserializeObject<ListYork>(par);


                var newCities =
                from p in parseData.NewYork
                where p.Properties.Neighborhood != ""
                select p.Properties.Neighborhood;

                var newCitiess = newCities.Distinct();


                //int count = 0;
                //foreach (var item in newCitiess)
                //{
                //    count++;
                //    Console.WriteLine($"{count}: {item}");
                //}

                var newerCity = parseData.NewYork
                    .Where(neighbor => neighbor.Properties.Neighborhood != "")
                    .Select(neigbor => neigbor.Properties.Neighborhood)
                    .Distinct();

                int counter = 0;
                foreach (var item in newerCity)
                {
                    counter++;
                    Console.WriteLine($"{counter}: {item}");
                }
                ////var distinctList = myList.DistinctBy( x => x.ObjectID).ToList();



            }
        }
    }
}
