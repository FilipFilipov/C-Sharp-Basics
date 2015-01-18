using System;
using System.Numerics;

class CalculateCombinations
{
    static void Main()
    {
        Console.WriteLine("Give two different integers over 1, starting with the bigger:");
        Console.Write("N = ");
        uint n = uint.Parse(Console.ReadLine());
        Console.Write("K = ");
        uint k = uint.Parse(Console.ReadLine());
        BigInteger factorial1 = 1;
        for (uint i = (k + 1); i <= n; i++)
        {
            factorial1 *= i;
        }
        BigInteger factorial2 = 1;
        for (int i = 1; i <= (n - k); i++)
        {
            factorial2 *= i;
        }
        Console.WriteLine("N!/(K! * (N-K)!) = {0}", factorial1 / factorial2);
    }
}
