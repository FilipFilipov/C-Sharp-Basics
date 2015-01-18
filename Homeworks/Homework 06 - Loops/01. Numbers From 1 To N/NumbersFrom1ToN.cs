using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        Console.Write("How many numbers do you want to print? ");
        uint numbers = uint.Parse(Console.ReadLine());
        for (int i = 1; i <= numbers; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}
