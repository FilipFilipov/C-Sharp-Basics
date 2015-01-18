using System;

class Pairs
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int[] sums = new int [input.Length / 2];
        for (int i = 0; i < input.Length; i += 2)
        {
            sums[i / 2] = int.Parse(input[i]) + int.Parse(input[i + 1]);            
        }
        int maxdiff = 0;
        for (int i = 0; i < sums.Length - 1; i++)
        {
            int diff = Math.Abs(sums[i] - sums[i + 1]);
            maxdiff = Math.Max(diff, maxdiff);
        }
        if (maxdiff == 0)
        {
            Console.WriteLine("Yes, value={0}", sums[0]);
        }
        else
        {
            Console.WriteLine("No, maxdiff={0}", maxdiff);
        }
    }
}