using System;
using System.Collections.Generic;

class AverageLoadTimeCalculator
{
    static void Main()
    {
        Console.WriteLine("Enter report: ");       
        Dictionary<string, double> sites = new Dictionary<string, double>();
        Dictionary<string, int> counters = new Dictionary<string, int>();
        string line = Console.ReadLine();
        while (!string.IsNullOrEmpty(line))
        {
            string[] list = line.Split(' ');
            string link = list[2];
            double loadTime = double.Parse(list[3]);
            if (!sites.ContainsKey(link))
            {
                sites.Add(link, loadTime);
                counters.Add(link, 1);
            }
            else
            {
                sites[link] += loadTime;
                counters[link] += 1;
            }
            line = Console.ReadLine();
        }
        foreach (string link in sites.Keys)
        {
            Console.WriteLine("{0} = {1}", link, sites[link] / counters[link]);
        }
    }
}

