using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_fleet_app
{
    class Program
    {
        static void Main(string[] args)
        {
            List<cars> listCars = new List<cars>
            {
                new cars("Oldsmobile", "442", 1970, 12000),
                new cars("Alfa Romeo", "Montreal", 1977, 120000),
                new cars("Alvis", "Crested", 1940, 98000)
            };
            //cars car1 = ;
            //cars car2 = ;
            //cars car3 = ;

            Fleet fleet = new Fleet(listCars);
            //fleet.Cars.Add(car1);
            //fleet.Cars.Add(car2);
            //fleet.Cars.Add(car3);

            Console.WriteLine("Fleet value: " + fleet.GetFleetValue());
            Console.WriteLine("\n");
            foreach (cars car in fleet.Cars) { 
            Console.WriteLine("Cars: " + car);
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n");
            var fleetstats = fleet.GetStats();
            Console.WriteLine("Highest value: " + fleetstats.HighestEntries);
            Console.WriteLine("Lowest value: " + fleetstats.LowestEntries);
            Console.WriteLine("Average value: " + fleetstats.AverageEntries);
            Console.WriteLine("\n");
            var Findall = fleet.GetCarsOfYear(1970);
            foreach (cars car in Findall)
            {
               // Console.WriteLine("CarsOfYear: \n" + car.);
            }



            Console.ReadLine();

        }
    }
};

       