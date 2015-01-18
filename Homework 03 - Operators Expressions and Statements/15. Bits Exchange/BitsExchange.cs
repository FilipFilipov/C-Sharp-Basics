using System;

class BitsExchange
{
    static void Main()
    {
        Console.Write("Enter an unsigned integer: ");
        uint input = uint.Parse(Console.ReadLine());
        uint bits_3_4_5 = (input >> 3) & 7;
        uint bits_24_25_26 = (input >> 24) & 7;
        uint inputZeros = input & (~(7u << 3)) & (~(7u << 24));
        uint result = inputZeros | (bits_3_4_5 << 24) | (bits_24_25_26 << 3);
        Console.WriteLine("{0} => {1}", input, result);
    }
}
