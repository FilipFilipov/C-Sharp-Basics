using System;

class PiggyBank
{
    static void Main()
    {
        int price = int.Parse(Console.ReadLine());
        int partyDays = int.Parse(Console.ReadLine());
        if (partyDays > 8)
        {
            Console.WriteLine("never");
            return;
        }
        double monthBalance = (30 - partyDays) * 2 - partyDays * 5;
        double monthsTotal = Math.Ceiling(price / monthBalance);
        Console.WriteLine("{0} years, {1} months", (int)monthsTotal / 12, monthsTotal % 12);
    }
}