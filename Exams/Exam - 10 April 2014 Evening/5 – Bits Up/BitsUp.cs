using System;

class BitsUp
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        int index = 0;
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            for (int bit = 7; bit >= 0; bit--)
            {                
                if (((step == 1) && (index != 0)) || (index % step == 1))
                {
                    number |= (1 << bit);
                }
                index++;
            }
            numbers[i] = number;
        }
        foreach (var num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}
