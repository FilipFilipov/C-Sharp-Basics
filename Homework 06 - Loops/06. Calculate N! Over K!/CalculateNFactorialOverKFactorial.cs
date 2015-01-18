using System;
using System.Numerics;

class CalculateNFactorialOverKFactorial
{
    static void Main()
    {
        Console.WriteLine("Give two different integers over 1, starting with the bigger:");
        Console.Write("N = ");
        uint n = uint.Parse(Console.ReadLine());
        Console.Write("K = ");
        uint k = uint.Parse(Console.ReadLine());
        BigInteger factorial = 1;
        for (uint i = (k + 1); i <= n; i++)
        {
            factorial *= i;
        }
        Console.WriteLine("N!/K! = {0}", factorial);
    }
}
