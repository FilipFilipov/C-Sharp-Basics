using System;

class ProgrammerDNA
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char letter = char.Parse(Console.ReadLine());
        int dotCount = 0;
        int letterCount = 0;
        for (int i = 0; i < n; i++)
        {
            switch (i % 7)
            {
                case 0:
                case 6:
                    dotCount = 3;
                    letterCount = 1; break;
                case 1:
                case 5:
                    dotCount = 2;
                    letterCount = 3; break;
                case 2:
                case 4:
                    dotCount = 1;
                    letterCount = 5; break;
                case 3:
                    dotCount = 0;
                    letterCount = 7; break;
            }
            string dots = new string('.', dotCount);
            Console.Write(dots);
            for (int j = 0; j < letterCount; j++)
            {
                Console.Write(letter);
                if (letter == 'G')
                {
                    letter = 'A';
                }
                else
                {
                    letter++;
                }
            }
            Console.WriteLine(dots);
        }
    }
}
