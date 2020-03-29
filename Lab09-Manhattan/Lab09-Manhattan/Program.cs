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

            
                var par = reader.ReadToEnd();

                var parseData = JsonConvert.DeserializeObject<ListYork>(par);

                int counts = 0;
                Console.WriteLine("This is showing all of the neighborhood");
                foreach (var item in parseData.NewYork)
                {
                    counts++;
                    Console.WriteLine($"{counts}: {item.Properties.Neighborhood}");
                }
                Console.WriteLine();

                var newCities =
                from p in parseData.NewYork
                where p.Properties.Neighborhood != ""
                select p.Properties.Neighborhood;

                Console.WriteLine("This is after trimming down null neighbors");
                int count = 0;
                foreach (var item in newCities)
                {
                    count++;
                    Console.WriteLine($"{count}: {item}");
                }
                Console.WriteLine();

                var newCitiess = newCities.Distinct();
                Console.WriteLine("This is after neighborhood is cleaned out of duplicate");
                foreach (var item in newCitiess)
                {
                    count++;
                    Console.WriteLine($"{count}: {item}");
                }
                Console.WriteLine();

                var newerCity = parseData.NewYork
                    .Where(neighbor => neighbor.Properties.Neighborhood != "")
                    .Select(neigbor => neigbor.Properties.Neighborhood)
                    .Distinct();

                Console.WriteLine("This is one liner");
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
