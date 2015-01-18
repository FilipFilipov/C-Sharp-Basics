using System;

class Plane
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int outerDots = 3 * n / 2;
        int innerDots = -1;
        Console.WriteLine("{0}*{0}", new string ('.', outerDots));
        while(innerDots < n + 2)
        {
            outerDots --;
            innerDots += 2;
            Console.WriteLine("{0}*{1}*{0}", new string ('.', outerDots), new string ('.', innerDots));
        }
        while (outerDots != 1)
        {
            outerDots -= 2;
            innerDots += 4;
            Console.WriteLine("{0}*{1}*{0}", new string ('.', outerDots), new string ('.', innerDots));
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
        Console.WriteLine(new string ('*', 3 * n));
    }
}
