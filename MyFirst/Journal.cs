using System;
namespace AccountingApp { 
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
}
}
