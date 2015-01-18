using System;

class Eclipse
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string frame = new string('*', n * 2 - 2);
        string spacer = new string(' ', n - 1);
        string lens = new string('/', n * 2 - 2);
        Console.WriteLine(" {0} {1} {0} ", frame, spacer);
        for (int i = 0; i < n - 2; i++)
        {
            if (i == (n - 2) / 2)
            {
                Console.WriteLine("*{0}*{1}*{0}*", lens, new string('-', n - 1));
            }
            else
            {
                Console.WriteLine("*{0}*{1}*{0}*", lens, spacer);
            }
        }
        Console.WriteLine(" {0} {1} {0} ", frame, spacer);
    }
}
