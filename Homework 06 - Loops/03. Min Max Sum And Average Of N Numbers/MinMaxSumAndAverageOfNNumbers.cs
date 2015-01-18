using System;

class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        Console.Write("How many numbers do you want to enter? ");
        uint numbers = uint.Parse(Console.ReadLine());
        int min = int.MaxValue;
        int max = int.MinValue;
        long sum = 0;
        for (int i = 0; i < numbers; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());
            if (currentNumber < min)
            {
                min = currentNumber;
            }
            if (currentNumber > max)
            {
                max = currentNumber;
            }
            sum += currentNumber;
        }
        Console.WriteLine("min = {0}\nmax = {1}\nsum = {2}\naverage = {3:F2}",
            min, max, sum, ((float)sum / numbers));
    }
}
