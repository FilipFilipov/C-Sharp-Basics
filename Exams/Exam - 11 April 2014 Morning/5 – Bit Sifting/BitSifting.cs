using System;

class BitSifting
{
    static void Main()
    {
        ulong bits = ulong.Parse(Console.ReadLine());
        int sieves = int.Parse(Console.ReadLine());
        for (int i = 0; i < sieves; i++)
        {
            ulong sieve = ulong.Parse(Console.ReadLine());
            bits &= (~sieve);
        }
        int bitCount = 0;
        while (bits != 0)
        {
            if ((bits & 1) == 1)
            {
                bitCount++;
            }
            bits >>= 1;
        }
        Console.WriteLine(bitCount);
    }
}
