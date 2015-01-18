using System;

class CheckForAPlayCard
{
    static void Main()
    {
        Console.Write("Enter a card sign to check if it's valid: ");
        string card = Console.ReadLine();
        switch (card)
        {
            case "A":
            case "J":
            case "K":
            case "Q":
                Console.WriteLine("yes"); break;
            default:
                int cardNum = 0;
                if (int.TryParse(card, out cardNum))
                {
                    if (cardNum >= 2 && cardNum <= 10)
                    {
                        Console.WriteLine("yes"); break;
                    }
                }
                Console.WriteLine("no"); break;
        }   
    }
}
