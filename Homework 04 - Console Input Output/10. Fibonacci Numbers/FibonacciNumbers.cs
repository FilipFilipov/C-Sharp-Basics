using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("How many numbers do you want to print? ");
        uint number = uint.Parse(Console.ReadLine());
        int f0 = 0;
        int f1 = 1;
        if (number == 1)
        {
            Console.WriteLine(f0);
        }
        else if (number == 2)
        {
            Console.WriteLine(f0 + " " + f1);
        }
        else
        {
            Console.Write(f0 + " " + f1 + " ");
            for (int i = 0; i < (number - 2); i++)
            {
                Console.Write((f0 + f1) + " ");
                f1 += f0;
                f0 = f1 - f0;
            }
        }
    }
}
