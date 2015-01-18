using System;

class CheckABitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Enter an unsigned integer: ");
        uint input = uint.Parse(Console.ReadLine());
        Console.Write("Enter a bit number to check if it's 1: ");
        int shift = int.Parse(Console.ReadLine());
        uint bit = (input >> shift) & 1;
        Console.WriteLine(bit == 1 ? true : false);
    }
}

