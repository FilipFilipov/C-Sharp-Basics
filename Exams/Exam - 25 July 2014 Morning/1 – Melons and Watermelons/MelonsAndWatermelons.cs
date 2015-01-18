using System;

class MelonsAndWatermelons
{
    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int days = int.Parse(Console.ReadLine());
        long melons = 0;
        long watermelons = 0;
        for (int i = start; i < start + days; i++)
        {
            switch (i % 7)
            {
                case 1:
                    watermelons += 1; break;
                case 2:
                    melons += 2; break;
                case 3:
                    watermelons += 1;
                    melons += 1; break;
                case 4:
                    watermelons += 2; break;
                case 5:
                    watermelons += 2;
                    melons += 2; break;
                case 6:
                    watermelons += 1;
                    melons += 2; break;
            }
        }
        long difference = watermelons - melons; 
        if (difference > 0)
        {
            Console.WriteLine(difference + " more watermelons");
        }
        else if (difference < 0)
        {
            Console.WriteLine(-difference + " more melons");
        }
        else
        {
            Console.WriteLine("Equal amount: " + melons);
        }
    }
}