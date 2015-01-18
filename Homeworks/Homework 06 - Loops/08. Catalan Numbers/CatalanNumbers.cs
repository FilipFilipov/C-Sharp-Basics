using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {        
        Console.Write("Give a number between 1 and 100: ");
        uint n = uint.Parse(Console.ReadLine());
        BigInteger factorial1 = 1;
        for (uint i = (n + 2); i <= (2 * n); i++)
        {
            factorial1 *= i;
        }
        BigInteger factorial2 = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial2 *= i;
        }
        Console.WriteLine("Cn = {0}", factorial1 / factorial2);
    }
}