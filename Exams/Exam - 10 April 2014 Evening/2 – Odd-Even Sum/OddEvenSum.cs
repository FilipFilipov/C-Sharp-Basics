using System;

class OddEvenSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        long sumOdd = 0;
        long sumEven = 0;
        bool odd = true;
        for (int i = 0; i < (2 * n); i++)
        {
            int number = int.Parse(Console.ReadLine());
            if (odd)
	        {
                sumOdd += number;
	        }
            else
            {
                sumEven += number;
            }
            odd = !odd;
        }
        if (sumOdd == sumEven)
        {
            Console.WriteLine("Yes, sum={0}", sumOdd);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(sumOdd - sumEven));
        }
    }
}
