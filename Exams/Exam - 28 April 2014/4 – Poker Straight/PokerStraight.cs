using System;

class PokerStraight
{
    static void Main()
    {
        int targetWeight = int.Parse(Console.ReadLine());
        int count = 0;
        for (int face = 1; face <= 10; face++)
        {
            for (int suit1 = 1; suit1 <= 4; suit1++)
            {
                for (int suit2 = 1; suit2 <= 4; suit2++)
                {
                    for (int suit3 = 1; suit3 <= 4; suit3++)
                    {
                        for (int suit4 = 1; suit4 <= 4; suit4++)
                        {
                            for (int suit5 = 1; suit5 <= 4; suit5++)
                            {
                                int weight =
                                    face * 10 + suit1 +
                                    (face + 1) * 20 + suit2 +
                                    (face + 2) * 30 + suit3 +
                                    (face + 3) * 40 + suit4 +
                                    (face + 4) * 50 + suit5;
                                if (weight == targetWeight)
                                {
                                    count++;
                                }
                            }
                        }
                    }
                }
            }
        }
        Console.WriteLine(count);
    }
}
