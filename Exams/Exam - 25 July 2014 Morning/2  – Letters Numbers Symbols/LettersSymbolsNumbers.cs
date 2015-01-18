using System;

class LettersSymbolsNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        long letters = 0;
        long numbers = 0;
        long symbols = 0;
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine().ToLower();
            for (int j = 0; j < input.Length; j++)
            {
                char ch = input[j];
                if (ch >= 'a' && ch <= 'z')
                {
                    letters += (ch - 'a' + 1) * 10;
                }
                else if (ch >= '0' && ch <= '9')
                {
                    numbers += (ch - '0') * 20;
                }
                else if (!Char.IsWhiteSpace(ch))
                {
                    symbols += 200;
                }
            }
        }
        Console.WriteLine("{0}\n{1}\n{2}", letters, numbers, symbols);
    }
}