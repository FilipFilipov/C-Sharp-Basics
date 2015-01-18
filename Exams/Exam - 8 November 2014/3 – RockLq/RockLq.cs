using System;

class RockLq
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int outerDots = n;
        int innerDots = n + 2;
        Console.WriteLine("{0}{1}{0}", new string('.', outerDots), new string('*', outerDots));
        while (outerDots != 1)
        {
            outerDots -= 2;
            Console.WriteLine("{0}*{1}*{0}", new string('.', outerDots), new string('.', innerDots));
            innerDots += 4;
        }
        int wingDots = n - 2;
        innerDots = n;
        Console.WriteLine("*{0}*{1}*{0}*", new string('.', wingDots), new string('.', innerDots));
        while (wingDots != 1)
        {
            wingDots -= 2;
            Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*", new string('.', wingDots),
                new string('.', outerDots), new string('.', innerDots));
            outerDots += 2;
        }
        outerDots = innerDots;
        while (outerDots != 1)
        {
            outerDots--;
            Console.WriteLine("{0}*{1}*{0}", new string('.', outerDots), new string('.', innerDots));
            innerDots += 2;
        }
        Console.WriteLine(new string('*', 3 * n));
    }
}
