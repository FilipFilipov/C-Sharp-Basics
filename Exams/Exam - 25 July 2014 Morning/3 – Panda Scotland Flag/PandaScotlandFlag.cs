using System;

class PandaScotlandFlag
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sharps = n;
        int tildes = -1;
        int letter = 0;
        for (int i = 0; i < n; i++)
        {
            if (i != n/2)
            {
                if (i < n / 2)
                {
                    tildes += 1;
                    sharps -= 2;
                }
                Console.WriteLine("{0}{1}{2}{3}{0}",
                    new string('~', tildes), (char)('A' + letter % 26),
                    new string('#', sharps), (char)('A' + (letter + 1) % 26));
                if (i > n / 2)
                {
                    tildes -= 1;
                    sharps += 2;
                }
                letter += 2;
            }
            else
            {
                Console.WriteLine("{0}{1}{0}", new string('-', n / 2), (char)('A' + letter % 26));
                letter += 1;
            }            
        }
    }
}
