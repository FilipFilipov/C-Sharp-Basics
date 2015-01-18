using System;

class SumOfElements
{
    static void Main()
    {
        string [] input = (Console.ReadLine().Split(' '));
        int[] numbers = new int[input.Length];
        long sum = 0;
        int biggest = int.MinValue;
        for (int i = 0; i < input.Length; i++)
		{
            numbers[i] = int.Parse(input[i]);
            sum += numbers[i];
            biggest = Math.Max(biggest, numbers[i]);
		}
        if (sum / 2.0 == biggest)
        {
            Console.WriteLine("Yes, sum={0}", biggest);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(sum - (long)biggest * 2));
        }
    }
}
