using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingApp
{
    public class EntriesStatics
    {
        

      public  float AverageEntries;
       public float HighestEntries;
       public float LowestEntries;
        public int Count;
        public EntriesStatics()
        {
            HighestEntries = 0;
            LowestEntries = float.MaxValue;
           }
    }
}
