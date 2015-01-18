using System;

class NumbersInIntervalDividableByGivenNumber
{
    static void Main()
    {
        uint count = 0;
        Console.WriteLine("Enter two positive integers:");
        uint a = uint.Parse(Console.ReadLine());
        uint b = uint.Parse(Console.ReadLine());
        for (uint i = Math.Min(a,b); i <= Math.Max(a,b); i++)
        {
            if (i % 5 == 0)
            {
                count++;
            }
        }
        Console.WriteLine("There are {0} number in that interval that are dividable by 5.", count);
    }
}
