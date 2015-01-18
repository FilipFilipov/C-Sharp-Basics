using System;

class MagicDates
{
    static void Main()
    {
        int startYear = int.Parse(Console.ReadLine());
        int endYear = int.Parse(Console.ReadLine());
        int magicWeight = int.Parse(Console.ReadLine());
        bool magic = false;
        DateTime start = new DateTime(startYear, 1, 1);
        DateTime end = new DateTime(endYear, 12, 31);
        int[] digits = new int[8];
        for (DateTime date = start; date <= end; date = date.AddDays(1))
        {            
            digits[0] = date.Day / 10;
            digits[1] = date.Day % 10;
            digits[2] = date.Month / 10;
            digits[3] = date.Month % 10;
            digits[4] = date.Year / 1000;
            digits[5] = (date.Year / 100) % 10;
            digits[6] = (date.Year / 10) % 10;
            digits[7] = date.Year % 10;
            int weight = 0;
            for (int i = 0; i < digits.Length; i++)
            {
                for (int j = (i + 1); j < digits.Length; j++)
                {
                    weight += digits[i] * digits[j];                  
                }
            }
            if (weight == magicWeight)
            {
                magic = true;
                Console.WriteLine("{0:d2}-{1:d2}-{2}", date.Day, date.Month, date.Year);
            }
        }
        if (!magic)
        {
            Console.WriteLine("No");
        }
    }
}
