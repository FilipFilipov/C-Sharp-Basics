using System;

class PrintADeckOf52Cards
{
    static void Main()
    {
        for (int n = 2; n < 15; n++)
        {
            for (int s = 0; s < 4; s++)
            {
                if (n != 10)
                {
                    Console.Write(" ");
                }
                switch (n)
                {                                       
                    case 11:
                        Console.Write("J");
                        break;
                    case 12:
                        Console.Write("Q");
                        break;
                    case 13:
                        Console.Write("K");
                        break;
                    case 14:
                        Console.Write("A");
                        break;
                    default:
                        Console.Write(n);
                        break;
                }
                switch (s)
                {
                    case 0:
                        Console.Write("♠ ");
                        break;
                    case 1:
                        Console.Write("♥ ");
                        break;
                    case 2:
                        Console.Write("♣ ");
                        break;
                    case 3:
                        Console.Write("♦ ");
                        break;
                }
            }
            Console.WriteLine();
        }
    }
}
