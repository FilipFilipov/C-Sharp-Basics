using System;

class Budget
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int daysOut = int.Parse(Console.ReadLine());
        int home = int.Parse(Console.ReadLine());
        int costs = 150 + (4 - home) * 2 * 20 + (30 - 8 - daysOut) * 10 + daysOut * (10 + (int)(n * 0.03));
        int difference = n - costs;
        if (difference > 0)
        {
            Console.WriteLine("Yes, leftover {0}.", difference);
        }
        else if (difference < 0)
        {
            Console.WriteLine("No, not enough {0}.", -difference);
        }
        else
        {
            Console.WriteLine("Exact Budget.");
        }
    }
}
