using System;

class ExtractABitFromAnInteger
{
    static void Main()
    {
        Console.Write("Enter an unsigned integer: ");
        uint input = uint.Parse(Console.ReadLine());
        Console.Write("Enter the bit you want to check: ");
        int shift = int.Parse(Console.ReadLine());
        uint bit = (input >> shift) & 1;
        Console.WriteLine("Bit number {0} is {1}.", shift ,bit);
    }
}