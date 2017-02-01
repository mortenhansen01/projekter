using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_fleet_app
{
    public class Fleet
    {
        public List<cars> Cars;
        public int year;
        public Fleet()
        {
            Cars = new List<cars>();
        }
        public Fleet(List<cars> listcars)
        {
            Cars = listcars;
        }
        public double GetFleetValue()
        {
            return Cars.Sum(car => car.GetCurrentValue());
        }
        public List<cars> GetCarsOfYear(int aar)
        {
           
            return Cars.FindAll(car => car.GetYear() == aar);
        }

        public FleetStats GetStats()
        {
            
            FleetStats fleetstats = new FleetStats();
            double sum = 0;
            foreach (cars car in Cars)
            {
                fleetstats.HighestEntries = Math.Max(car.GetCurrentValue(), fleetstats.HighestEntries);
                fleetstats.LowestEntries = Math.Min(car.GetCurrentValue(), fleetstats.LowestEntries);

                sum += car.GetCurrentValue();
                 }
            fleetstats.AverageEntries = sum / Cars.Count;

            return fleetstats;
        }

    }
}

