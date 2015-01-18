using System;

class HalfSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        long sumFirstHalf = 0;
        for (int i = 0; i < n; i++)
        {
            sumFirstHalf += int.Parse(Console.ReadLine());
        }
        long sumSeconfHalf = 0;
        for (int i = 0; i < n; i++)
        {
            sumSeconfHalf += int.Parse(Console.ReadLine());
        }
        if (sumFirstHalf == sumSeconfHalf)
        {
            Console.WriteLine("Yes, sum={0}", sumFirstHalf);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(sumFirstHalf - sumSeconfHalf));
        }
    }
}
