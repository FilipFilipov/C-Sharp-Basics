using System;

class FruitMarket
{
    static void Main()
    {
        string day = Console.ReadLine();
        decimal quantity1 = decimal.Parse(Console.ReadLine());
        string product1 = Console.ReadLine();
        decimal quantity2 = decimal.Parse(Console.ReadLine());
        string product2 = Console.ReadLine();
        decimal quantity3 = decimal.Parse(Console.ReadLine());
        string product3 = Console.ReadLine();
        decimal price = quantity1 * CalculatePrice(product1, day) + quantity2 * CalculatePrice(product2, day) +
            quantity3 * CalculatePrice(product3, day);
        Console.WriteLine("{0:F2}", price);
    }

    private static decimal CalculatePrice(string product, string day)
    {
        decimal price = 0;
        bool vegtable = false;
        switch (product)
        {
            case "banana":
                price = 1.8m; break;
            case "cucumber":
                price = 2.75m;
                vegtable = true; break;
            case "tomato":
                price = 3.20m;
                vegtable = true; break;
            case "orange":
                price = 1.60m; break;
            case "apple":
                price = 0.86m; break;
        }
        switch (day)
        {
            case "Friday":
                price *= 0.90m; break;
            case "Sunday":
                price *= 0.95m; break;
            case "Tuesday":
                if (!vegtable)
                {
                    price *= 0.80m;
                }
                break;
            case "Wednesday":
                if (vegtable)
                {
                    price *= 0.90m;
                }
                break;
            case "Thursday":
                if (product == "banana")
                {
                    price *= 0.70m;
                }
                break;
        }
        return price;
    }
}
