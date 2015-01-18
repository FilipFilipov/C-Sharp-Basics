using System;

class BitFlipper
{
    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());
        for (int position = 61; position >= 0; position--)
        {
            ulong last3Bits = (number >> position) & 7;
            if (last3Bits == 0 || last3Bits == 7)
            {
                number ^= (7ul << position);
                position -= 2;
            }
        }
        Console.WriteLine(number);
    }
}
