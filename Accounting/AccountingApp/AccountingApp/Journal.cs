using System;
using System.Collections.Generic;

namespace AccountingApp
{
    public class Journal
    {
        public Journal()
        {
            entries = new List<float>();
        }
        List<float> entries;
        public void AddEntry(float entry)
        {
            entries.Add(entry);
        }
        public EntriesStatics ComputeStatistice()
        {
        var stats = new EntriesStatics();
            float sum = 0;
           foreach (float entry in entries)
            {
                stats.HighestEntries = Math.Max(entry, stats.HighestEntries);
                stats.LowestEntries = Math.Min(entry, stats.LowestEntries);
                
                sum += entry;
                stats.Count += 1; 
            }
            stats.AverageEntries = sum / stats.Count;
            
            return stats;    
        }
    }
}