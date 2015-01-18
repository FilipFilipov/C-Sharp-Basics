using System;

class OddOrEvenCounter
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int count = int.Parse(Console.ReadLine());
        string oddness = Console.ReadLine();
        int checker = (oddness == "odd") ? 1 : 0;
        int counter = 0;
        int order = 0;
        for (int i = 0; i < n; i++)
        {
            int tempCounter = 0;
            for (int j = 0; j < count; j++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber % 2 == checker)
                {
                    tempCounter++;
                    if (tempCounter > counter)
                    {
                        counter = tempCounter;
                        order = i;
                    }
                }
            }
        }
        string[] ordinal = { "First", "Second", "Third", "Fourth", "Fifth",
                               "Sixth", "Seventh", "Eighth", "Ninth", "Tenth" };
        if (counter != 0)
        {
            Console.WriteLine("{0} set has the most {1} numbers: {2}", ordinal[order], oddness, counter);
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
