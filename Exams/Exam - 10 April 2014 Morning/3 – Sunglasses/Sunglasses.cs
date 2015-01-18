using System;

class Sunglasses
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string frame = new string('*', 2 * n);
        string spacer = new string(' ', n);
        string lens = new string('/', 2 * n - 2);
        Console.WriteLine("{0}{1}{0}", frame, spacer);
        for (int i = 0; i < n - 2; i++)
        {
            if (i == (n - 2) / 2)
            {
                Console.WriteLine("*{0}*{1}*{0}*", lens, new string('|', n));
            }
            else
            {
                Console.WriteLine("*{0}*{1}*{0}*", lens, spacer);
            }
        }
        Console.WriteLine("{0}{1}{0}", frame, spacer);
    }
}