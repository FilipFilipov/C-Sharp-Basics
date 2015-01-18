using System;

class BitRoller
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int f = int.Parse(Console.ReadLine());
        int r = int.Parse(Console.ReadLine());
        for (int i = 0; i < r; i++)
        {
            n = RollBitsRight(n, f);
        }           
        Console.WriteLine(n);
    }

    private static int RollBitsRight(int n, int f)
    {
        int result = 0;
        for (int i = 0; i < 19; i++)
        {
            int bit = (n >> i) & 1;
            if (i == f)
            {
                result |= (bit << f);
            }
            else
            {
                int newPos = i - 1;
                if (newPos < 0)
                {
                    newPos = 18;
                }
                if (newPos == f)
                {
                    newPos--;
                }
                result |= (bit << newPos);
            }
        }
        return result;
    }
}
