using System;

class PrimeChecker
{
    static void Main()
    {
        Console.Write("Enter a positive integer: ");
        ulong n = ulong.Parse(Console.ReadLine());
        Console.WriteLine(IsPrime(n));
    }

    static bool IsPrime (ulong n)
    {
        switch (n)
        {
            case 0:
            case 1:
                return false;
            default:
                for (ulong i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
                return true;
        }
    }
}
