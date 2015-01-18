using System;

class Boat
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string rearDots = new string('.', n);
        int astersk = 1;
        bool midPointPassed = false;
        while (astersk > 0)
        {
            if (astersk >= n)
            {
                midPointPassed = true;
            }
            Console.WriteLine("{0}{1}{2}",
                new string('.', n - astersk), new string('*', astersk), rearDots);
            astersk += midPointPassed ? -2 : 2;
        }
        int sideDots = 0;
        for (int i = 0; i < (n - 1) / 2; i++)
        {
            Console.WriteLine("{0}{1}{0}",
                new string('.', sideDots), new string('*', 2 * (n - sideDots)));
            sideDots++;
        }
    }
}