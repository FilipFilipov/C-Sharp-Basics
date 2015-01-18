using System;

class SequenceOfKNumbers
{
    static void Main()
    {
        string[] numbers = Console.ReadLine().Split(' ');
        int k = int.Parse(Console.ReadLine());
        if (k == 1)
        {
            Console.WriteLine();
            return;
        }
        int sequence = 1;
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            sequence = (numbers[i] == numbers[i + 1]) ? ++sequence: 1;
            if (sequence == k)
            {
                for (int j = i + 2 - k; j <= i + 1; j++)
                {
                    numbers[j] = null;
                }
                sequence = 1;
            }
        }
        foreach (var num in numbers)
        {
            if (num != null)
            {
                Console.Write(num + " ");
            }
        }
    }
}
