using System;

class ChangeEvenBits
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        if (count == 0)
        {
            ulong bitsZero = ulong.Parse(Console.ReadLine());
            Console.WriteLine(bitsZero);
            Console.WriteLine(0);
            return;
        }
        int maxNumber = int.Parse(Console.ReadLine());
        for (int i = 0; i < count - 1; i++)
        {
            int number = int.Parse(Console.ReadLine());
            maxNumber = Math.Max(number, maxNumber);
        }
        ulong bits = ulong.Parse(Console.ReadLine());
        int length = 0;
        do
        {
            maxNumber /= 2;
            length++;
        } while (maxNumber > 0);
        int changes = 0;
        for (int bit = 0; bit < 2 * length; bit += 2)
        {
            ulong mask = 1uL << bit;
            if ((bits & mask) == 0)
            {
                changes++;
            }
            bits |= mask;
        }
        Console.WriteLine(bits + "\n" + changes);
    }
}
