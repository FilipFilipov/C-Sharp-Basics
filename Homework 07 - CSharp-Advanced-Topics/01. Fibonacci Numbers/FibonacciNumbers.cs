using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("Which Fibonachcci number do you want to print? ");
        uint n = uint.Parse(Console.ReadLine());
        Console.WriteLine(Fibonachcci(n));
    }

    static int Fibonachcci (uint n)
    {
        if (n == 0)
        {
            return 0;
        }
        int f1 = 0;
        int f2 = 1;
        for (int i = 0; i < n; i++)
        {
            int oldF1 = f1;
            f1 = f2;
            f2 += oldF1;
        }
        return f2;
        }
}
