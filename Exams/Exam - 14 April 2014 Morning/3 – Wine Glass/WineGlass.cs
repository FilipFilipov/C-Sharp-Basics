using System;

class WineGlass
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int dotsCount = 0;
        for (int i = 0; i < n/2; i++)
        {
            if (i > 0)
            {
                dotsCount++;
            }
            Console.WriteLine("{0}\\{1}/{0}", new string('.', dotsCount), new string('*', (n - 2 - dotsCount * 2)));
        }
        for (int i = 0; i < (n/2) - 2; i++)
        {
            Console.WriteLine("{0}||{0}", new string('.', dotsCount));
        }
        string dashes = new string('-', n);
        if (n < 12)
        {
            Console.WriteLine("{0}||{0}", new string('.', dotsCount));
        }
        else
        {
            Console.WriteLine(dashes);
        }
        Console.WriteLine(dashes);
    }
}
