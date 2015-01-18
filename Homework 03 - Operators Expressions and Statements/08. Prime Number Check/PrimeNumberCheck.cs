using System;

class PrimeNumberCheck
{
    static void Main()
    {        
        Console.Write("Enter a positive integer to check if it's prime: ");
        uint n = uint.Parse(Console.ReadLine());
        switch (n)
        {
            case 0:
            case 1:
                Console.WriteLine("False");
                break;
            default:
                bool isPrime = true;
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {                   
                    if (n % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine(isPrime);
                break;
        }
    }
}