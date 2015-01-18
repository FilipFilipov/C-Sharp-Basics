using System;

class BabaTincheAirlines
{
    static void Main()
    {
        int[] passengers = new int[3];
        int income = 0;
        int maxProfit = 0;
        int price = 0;
        int[] prices = { 7000, 3500, 1000 };
        for (int i = 0; i < 3; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            price = prices[i];
            for (int j = 0; j < 3; j++)
            {
                passengers[j] = int.Parse(input[j]);
            }         
            income += (int)((passengers[0] - passengers[1]) * price +
                passengers[1] * 0.3m * price + passengers[2] * 0.005m * price);
        }
        maxProfit = (int)((12 * 7000 * 1.005m) + 28 * 3500 * 1.005m + 50 * 1000 * 1.005m);
        Console.WriteLine(income);
        Console.WriteLine(maxProfit - income);
    }
}
