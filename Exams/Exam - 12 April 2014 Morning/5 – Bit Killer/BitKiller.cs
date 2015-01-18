using System;

class BitKiller
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int index = 0;
        int outputByte = 0;
        int bitCount = 0;
        for (int i = 0; i < n; i++)
        {
            int bits = int.Parse(Console.ReadLine());
            for (int bitNumber = 7; bitNumber >= 0; bitNumber--)
            {
                if (!((step == 1 && index > 0) || (index % step == 1)))
                {
                    int bit = (bits >> bitNumber) & 1;
                    outputByte <<= 1;
                    outputByte |= bit;
                    bitCount++;
                    if (bitCount == 8)
                    {
                        Console.WriteLine(outputByte);
                        outputByte = 0;
                        bitCount = 0;
                    }
                }
                index++;
            }
        }
        if (bitCount > 0)
        {
            outputByte <<= (8 - bitCount);
            Console.WriteLine(outputByte);
        }
    }
}