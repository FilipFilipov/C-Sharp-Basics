using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter an unsigned integer: ");
        uint input = uint.Parse(Console.ReadLine());
        uint bit = (input >> 3) & 1;
        Console.WriteLine("Bit number 3 is {0}.", bit);
    }
}
