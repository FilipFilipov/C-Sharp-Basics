using System;

class ModiyABitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Enter an unsigned integer: ");
        uint input = uint.Parse(Console.ReadLine());
        Console.Write("Enter the bit you want to set: ");
        int shift = int.Parse(Console.ReadLine());
        Console.Write("Enter the value you want to set it to: ");
        int v = int.Parse(Console.ReadLine());
        uint aSet1 = input | (1u << shift);
        uint aSet0 = input & (~(1u << shift));
        Console.WriteLine("{0} => {1}", input, v == 0 ? aSet0 : aSet1);
    }
}
