using System;

class Star
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int leftPosition = n + 1;
        int rightPosition = n + 1;
        for (int i = 0; i < n / 2; i++)
        {
            for (int j = 1; j <= n * 2 + 1; j++)
            {
                bool starPos = j == leftPosition || j == rightPosition;
                Console.Write(starPos ? '*' : '.'); 
            }
            leftPosition--;
            rightPosition++;
            Console.WriteLine();
        }
        Console.WriteLine("{0}{1}{0}", new string('*', n / 2 + 1), new string('.', n - 1));
        int outerDots = 1;
        int innerDots = 2 * n - 3;
        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', outerDots), new string('.', innerDots));
            outerDots++;
            innerDots -= 2;
        }
        int middleLeft = n + 1;
        int middleRight = n + 1;
        for (int i = 0; i < n / 2; i++)
        {
            for (int j = 1; j <= n * 2 + 1; j++)
            {
                bool starPos =
                    j == leftPosition || j == rightPosition ||
                    j == middleLeft || j == middleRight;
                Console.Write(starPos ? '*' : '.');
            }
            leftPosition--;
            rightPosition++;
            middleLeft--;
            middleRight++;
            Console.WriteLine();
        }
        Console.WriteLine("{0}{1}{0}", new string('*', n / 2 + 1), new string('.', n - 1));
    }
}
