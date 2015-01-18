using System;

class NumbersNotDivisibleBy3And7
{
    static void Main()
    {
        Console.Write("Give outer limit of the numbers to print: ");
        uint numbers = uint.Parse(Console.ReadLine());
        for (int i = 1; i <= numbers; i++)
        {
            if (!(i % 3 == 0 || i % 7 == 0))
            {
                Console.Write(i + " ");
            }            
        }
        Console.WriteLine();
    }
}
