using System;

class Gambling
{
    static void Main()
    {
        decimal cash = decimal.Parse(Console.ReadLine());
        string[] cards = Console.ReadLine().Split(' ');
        int houseHand = 0;
        for (int i = 0; i < cards.Length; i++)
        {
            switch (cards[i])
            {
                case "J":
                    houseHand += 11; break;
                case "Q":
                    houseHand += 12; break;
                case "K":
                    houseHand += 13; break;
                case "A":
                    houseHand += 14; break;
                default:
                    houseHand += int.Parse(cards[i]); break;
            }
        }
        int myHand = 0;
        int winningHands = 0;
        int totalHands = 0;
        for (int card1 = 2; card1 < 15; card1++)
        {
            for (int card2 = 2; card2 < 15; card2++)
            {
                for (int card3 = 2; card3 < 15; card3++)
                {
                    for (int card4 = 2; card4 < 15; card4++)
                    {
                        myHand = card1 + card2 + card3 + card4;
                        totalHands++;
                        if (myHand > houseHand)
                        {
                            winningHands++;
                        }
                    }
                }
            }
        }
        decimal probabilty = (decimal)winningHands / totalHands;
        decimal winnings = cash * 2 * probabilty;
        Console.WriteLine((probabilty < 0.5m) ? "FOLD" : "DRAW");
        Console.WriteLine("{0:F2}", winnings);
    }
}