using System;
using System.IO;
using System.Linq;
using Lab09_Manhattan.Classes;
using Newtonsoft.Json;

namespace Lab09_Manhattan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"
                        #=================#
                        # New York Finest #
                        #    by Jin       #
                        #=================#");
            Console.WriteLine("Press any key to proceed this application");
            Console.ReadLine();
            UsingJSON();
            Console.WriteLine("-------------------");
            Console.WriteLine("Sorry for a lot of enters, please enjoy rest of your day");
            Console.ReadLine();
            Environment.Exit(0);

        }


        public static void UsingJSON()
        {
            using (StreamReader reader = File.OpenText(@"../../../data.json"))
            {
                var par = reader.ReadToEnd();

                ListYork parseData = JsonConvert.DeserializeObject<ListYork>(par);

                int counts = 0;
                Console.WriteLine("This is showing all of the neighborhood");
                foreach (var item in parseData.NewYork)
                {
                    counts++;

                    Console.WriteLine($"{counts}: {item.Properties.Neighborhood}");
                }
                Console.WriteLine("-------------------");
                Console.WriteLine("Enter to see the neighborhoods without empty entry");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("");

                var newCities =
                from p in parseData.NewYork
                where p.Properties.Neighborhood != ""
                select p.Properties.Neighborhood;

                int count = 0;
                foreach (var item in newCities)
                {
                    count++;
                    Console.WriteLine($"{count}: {item}");
                }
                Console.WriteLine("-------------------");
                Console.WriteLine("Enter to see the neighborhoods without duplicates");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("");
                
                var newCitiess = newCities.Distinct();
                count = 0;
                foreach (var item in newCitiess)
                {
                    count++;
                    Console.WriteLine($"{count}: {item}");
                }

                Console.WriteLine("-------------------");
                Console.WriteLine("Enter to see the neighborhoods sorted out efficiently using one line technique");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("");

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
                Console.WriteLine("-------------------");
                Console.WriteLine("Enter to see the second question written in one liner");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("");

                var newNeighbor = parseData.NewYork
                    .Where(p => p.Properties.Neighborhood != "")
                    .Select(p => p.Properties.Neighborhood);

                count = 0;
                foreach (var item in newNeighbor)
                {
                    count++;
                    Console.WriteLine($"{count}: {item}");
                }
            }
        }
    }
}
