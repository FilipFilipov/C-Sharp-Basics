using System;

class WeirdCombinations
{
    static void Main()
    {
        string input = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());
        int count = 0;
        bool numberExists = false;
        foreach (var ch1 in input)
        {
            foreach (var ch2 in input)
            {
                foreach (var ch3 in input)
                {
                    foreach (var ch4 in input)
                    {
                        foreach (var ch5 in input)
                        {
                            if (count == n)
                            {
                                Console.WriteLine("" + ch1 + ch2 + ch3 + ch4 + ch5);
                                numberExists = true;
                            }
                            count++;
                        }
                    }
                }
            }
        }
        if (!numberExists)
        {
            Console.WriteLine("No");
        }
    }
}
