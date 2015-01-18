using System;

class BitShooter
{
    static void Main()
    {
        ulong field = ulong.Parse(Console.ReadLine());
        int center = 0;
        int size = 0;
        for (int i = 0; i < 3; i++)
        {
            string[] shot = Console.ReadLine().Split(' ');           
            center = int.Parse(shot[0]);
            size = int.Parse(shot[1]);
            for (int j = center - (size / 2); j <= center + (size / 2); j++)
            {
                if (j >= 0 && j < 64)
                {
                    ulong bit = 1ul << j;
                    if ((field & bit) != 0)
                    {
                        field ^= bit;
                    }
                }
            }
        }
        int countRight = 0;
        int countLeft = 0;
        for (int i = 0; i < 64; i++)
        {
            if (((field >> i) & 1) == 1)
            {
                if (i < 32)
                {
                    countRight++;
                }
                else
                {
                    countLeft++;
                }
            }
        }
        Console.WriteLine("left: {0}", countLeft);
        Console.WriteLine("right: {0}", countRight);
    }
}
