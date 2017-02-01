using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Car_fleet_app
{
    public class FleetStats
    {
        public double AverageEntries;
        public double HighestEntries;
        public double LowestEntries;
        public int Count;
        public FleetStats()
        {
            HighestEntries = 0;
            LowestEntries = double.MaxValue;
        }
    }
}
   