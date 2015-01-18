using System;

class Arrow
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string dots1 = new string('.', (n/2));
        Console.WriteLine("{0}{1}{0}", dots1, new string('#', n));
        string dots2 = new string('.', (n - 2));
        for (int i = 0; i < (n - 2); i++)
        {
            Console.WriteLine("{0}#{1}#{0}", dots1, dots2);
        }
        Console.WriteLine("{0}{1}{0}", new string('#', (n / 2 + 1)), dots2);
        int outerDots = 1;
        int innerDots = 2 * n - 5;
        while(innerDots > 0)
        {
            Console.WriteLine("{0}#{1}#{0}", new string('.', outerDots), new string('.', innerDots));
            outerDots++;
            innerDots -= 2;
        }
        Console.WriteLine("{0}#{0}", new string('.', (n-1)));
    }
}
