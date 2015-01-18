using System;

class FriendBits
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        uint friendBits = 0;
        uint aloneBits = 0;
        for (int i = 31; i >= 0; i--)
        {
            uint currentBit = (n >> i) & 1;
            uint leftBit = (n >> (i + 1)) & 1;                   
            uint rightBit = (n >> (i - 1)) & 1;
            if ((i != 31 && leftBit == currentBit) ||
                (i != 0 && rightBit == currentBit))
            {
                friendBits <<= 1;
                friendBits |= currentBit;
            }
            else
            {
                aloneBits <<= 1;
                aloneBits |= currentBit;
            }
        }
        Console.WriteLine(friendBits);
        Console.WriteLine(aloneBits);
    }
}
