using System;

class NewHouse
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int stars = 1;
        int dashes = n / 2;
        while (stars <= n)
        {
            Console.WriteLine("{0}{1}{0}", new string('-', dashes), new string('*', stars));
            stars += 2;
            dashes--;
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("|{0}|", new string('*', n - 2));
        }
    }
}
