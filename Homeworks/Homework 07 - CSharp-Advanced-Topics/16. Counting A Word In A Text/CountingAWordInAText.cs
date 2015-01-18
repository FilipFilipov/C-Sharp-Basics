using System;

class CountingAWordInAText
{
    static void Main()
    {
        char [] separators = { ' ', ',', '.', '?', '!', '"', '(', ')', '/', '@', ':', ';' };
        Console.Write("Enter the target word: ");
        string target = Console.ReadLine();
        Console.WriteLine("Enter some text:");
        string[] words = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine();
        int count = 0;
        foreach (var word in words)
        {
            if (word.Equals(target, StringComparison.InvariantCultureIgnoreCase))
            {
                count++;
            }
        }
        Console.WriteLine("The word \"{0}\" is contained in the text {1} times.", target, count);
    }
}
