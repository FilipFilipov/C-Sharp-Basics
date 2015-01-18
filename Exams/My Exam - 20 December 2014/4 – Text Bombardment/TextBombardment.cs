using System;

class TextBombardment
{
    static void Main()
    {
        char[] text = Console.ReadLine().ToCharArray();
        int width = int.Parse(Console.ReadLine());
        string[] bombs = Console.ReadLine().Split(' ');
        foreach (var bomb in bombs)
        {
            bool destroyed = false;
            for (int i = 0; i < text.Length; i++)
            {
                if (i % width == int.Parse(bomb))
                {
                    if (Char.IsWhiteSpace(text[i]) && destroyed ||
                        (Math.Ceiling(text.Length / (double)width) * width) - i < width - int.Parse(bomb))
                    {
                        break;
                    }
                    else if (!Char.IsWhiteSpace(text[i]))
                    {
                        text[i] = ' ';
                        destroyed = true;
                    }
                }
            }
        }
        foreach (var letter in text)
        {
            Console.Write(letter);
        }
    }
}
