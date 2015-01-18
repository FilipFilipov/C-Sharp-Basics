using System;

class XBits
{
    static void Main()
    {
        int[] numbers = new int[8];
        for (int i = 0; i < 8; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        int xBits = 0;
        for (int i = 0; i < 6; i++)
        {
            for (int bit = 0; bit < 30; bit++)
            {
                if ((((numbers [i] >> bit) & 7) == 5) &&
                    (((numbers [i + 1] >> bit) & 7) == 2) &&
                        (((numbers [i + 2] >> bit) & 7) == 5))
                {
                    xBits++;
                }
            }
        }
        Console.WriteLine(xBits);
    }
}
