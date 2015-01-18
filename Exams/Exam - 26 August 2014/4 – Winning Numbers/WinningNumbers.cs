using System;

class WinningNumbers
{
    static void Main()
    {
        string input = Console.ReadLine().ToLower();
        int sum = 0;
        bool win = false;
        foreach (char letter in input)
        {
            sum += letter - 'a' + 1;
        }
        for (int i = 111; i <= 999; i++)
        {
            if ((i / 100) * (i / 10 % 10) * (i % 10) == sum)
            {
                for (int j = 111; j <= 999; j++)
                {
                    if ((j / 100) * (j / 10 % 10) * (j % 10) == sum)
                    {
                        Console.WriteLine(i + "-" + j);
                        win = true;
                    }
                }
            }
        }
        if (!win)
        {
            Console.WriteLine("No");
        }
    }
}
