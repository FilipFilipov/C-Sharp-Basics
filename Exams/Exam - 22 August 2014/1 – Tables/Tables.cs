using System;

class Tables
{
    static void Main()
    {
        long bundle1 = long.Parse(Console.ReadLine());
        long bundle2 = long.Parse(Console.ReadLine());
        long bundle3 = long.Parse(Console.ReadLine());
        long bundle4 = long.Parse(Console.ReadLine());
        long tops = long.Parse(Console.ReadLine());
        long targetTables = long.Parse(Console.ReadLine());
        long legs = bundle1 + bundle2 * 2 + bundle3 * 3 + bundle4 * 4;
        long actualTables = Math.Min((legs / 4), tops);
        long diffrence = actualTables - targetTables;
        if (diffrence > 0)
        {
            Console.WriteLine("more: {0}", diffrence);
            Console.WriteLine("tops left: {0}, legs left: {1}", tops - targetTables, legs - (targetTables * 4));
        }
        else if (diffrence < 0)
        {
            long topsNeeded = (tops >= targetTables) ? 0 : targetTables - tops;
            long legsNeeded = (legs >= targetTables * 4) ? 0 : (targetTables * 4) - legs;
            Console.WriteLine("less: {0}", diffrence);
            Console.WriteLine("tops needed: {0}, legs needed: {1}", topsNeeded, legsNeeded);
        }
        else
        {
            Console.WriteLine("Just enough tables made: {0}", targetTables);
        }
    }
}
