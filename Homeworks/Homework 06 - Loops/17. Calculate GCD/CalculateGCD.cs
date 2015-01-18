using System;

class CalculateGCD
{
    static void Main()
    {
        Console.WriteLine("Give two different integers other than 0, starting with the bigger:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        while (b != 0)
        {
            int residual = a % b;
            a = b;
            b = residual;
        }
        Console.WriteLine("GCD = {0}", a);
    }
}
