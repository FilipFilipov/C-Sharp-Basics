using System;

class HouseWithAWindow
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int leftPosition = n;
        int rightPosition = n;
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= 2*n - 1; j++)
            {
                Console.Write((j == leftPosition || j == rightPosition) ? '*' : '.');                
            }
            leftPosition--;
            rightPosition++;
            Console.WriteLine();
        }
        string floor = new string('*', 2 * n - 1);
        Console.WriteLine(floor);
        for (int i = 0; i < n; i++)
        {
            if (i < n/4 || i >= 3 * n / 4)
            {
                Console.WriteLine("*{0}*", new string('.', n * 2 - 3));
            }
            else
            {
                Console.WriteLine("*{0}{1}{0}*", new string('.', n / 2), new string('*', n - 3));
            }
        }
        Console.WriteLine(floor);
    }
}
