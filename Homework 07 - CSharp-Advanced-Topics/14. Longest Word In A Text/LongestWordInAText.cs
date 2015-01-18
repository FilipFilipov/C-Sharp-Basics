using System;

class CountOfNames
{
    static void Main()
    {
        Console.WriteLine("Enter some text:");
        char[] separators = { ' ', ',', '.', '?', '!', '"', '(', ')', ':', ';' };
        string[] words = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
        string longest = "";
        Console.WriteLine();
        for (int i = 0; i < words.Length; i++)
        {
            if (longest.Length < words[i].Length)
            {
                longest = words[i];
            }
        }
        Console.WriteLine("The longest word in your text is: \"{0}\"", longest);
    }
}
