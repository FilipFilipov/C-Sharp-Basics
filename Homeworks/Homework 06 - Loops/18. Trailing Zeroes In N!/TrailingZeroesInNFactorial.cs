using System;

class TrailingZeroesInNFactorial
{
    static void Main()
    {
        Console.Write("Enter a positive integer: ");
        uint n = uint.Parse(Console.ReadLine());
        uint zeros = 0;
        while (n != 0)
        {
            zeros += n / 5;
            n /= 5;
        }
        Console.WriteLine("Number of trailing zeros is: {0}", zeros);
    }
}
