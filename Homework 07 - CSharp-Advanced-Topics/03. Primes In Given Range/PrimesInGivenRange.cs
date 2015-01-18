using System;
using System.Collections.Generic;

class PrimesInGivenRange
{
    static void Main()
    {
        Console.Write("Enter start of range: ");
        uint n = uint.Parse(Console.ReadLine());
        Console.Write("Enter end of range: ");
        uint m = uint.Parse(Console.ReadLine());
        if (n > m)
        {
            Console.WriteLine("(empty list)");
            return;
        }
        Console.WriteLine("Prime(s) in range {0}-{1} are: ", n, m);
        PrintPrimesInRange(FindPrimesInRange (n, m));
    }
    static List<uint> FindPrimesInRange (uint startNum, uint endNum)
    {
        List<uint> primesInRange = new List<uint>();
        for (uint i = startNum; i <= endNum; i++)
		{
            if (i > 1)
            {
                bool isPrime = true;
                for (uint j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primesInRange.Add(i);
                }
            }            
		}
        return primesInRange;
    }
    static void PrintPrimesInRange (List<uint> primesInRange)
    {
        if (primesInRange.Count == 0)
        {
            Console.WriteLine("(empty list)");
        }
        else
        {
            Console.Write(primesInRange[0]);
            for (int i = 1; i < primesInRange.Count; i++)
            {
                Console.Write(", " + primesInRange[i]);
            }
        }
        Console.WriteLine();
    }
}
