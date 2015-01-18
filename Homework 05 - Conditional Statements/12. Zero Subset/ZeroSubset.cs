using System;
using System.Collections.Generic;

class Subs0
{
    static void Main()
    {
        int[] n = new int[5];
        string[] values = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < 5; i++)
        {
            n[i] = int.Parse(values[i]);
        }
        bool zeroSubset = false;
        for (int i = 1; i < Math.Pow(2, 5); i++)
        {
            string pattern = Convert.ToString(i, 2).PadLeft(5, '0');
            int currentSum = 0;
            List<int> numbers = new List<int>();
            for (int j = 0; j < 5; j++)
            {
                if (pattern[j] == '1')
                {
                    currentSum += n[j];
                    numbers.Add(n[j]);
                }
            }
            if (currentSum == 0)
            {
                zeroSubset = true;
                if (numbers.Count > 1)
                {
                    for (int j = 0; j < numbers.Count - 1; j++)
                    {
                        Console.Write("{0} + ", numbers[j]);
                    }
                    Console.WriteLine("{0} = 0", numbers[numbers.Count - 1]);
                }
                else
                {
                    Console.WriteLine("0 = 0");
                }
            }
        }
        if (!zeroSubset)
        {
            Console.WriteLine("no zero suset");
        }
    }
}

