using System;

class JumpingSums
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int jumps = int.Parse(Console.ReadLine());
        int[] numbers = new int[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            numbers[i] = int.Parse(input[i]);            
        }
        long maxSum = 0;
        for (int i = 0; i < input.Length; i++)
        {            
            int index = i;
            long sum = numbers[index];
            for (int j = 0; j < jumps; j++)
            {                
                index = (index + numbers[index]) % numbers.Length;
                sum += numbers[index];
            }
            maxSum = Math.Max(sum, maxSum);
        }
        Console.WriteLine("max sum = {0}", maxSum);
    }
}
