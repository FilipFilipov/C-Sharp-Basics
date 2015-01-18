using System;
using System.Collections.Generic;

class CountOfLetters
{
    static void Main()
    {
        Console.WriteLine("Enter a list of characters, separated by a space:");
        char[] letters = Console.ReadLine().Replace(" ", "").ToCharArray();
        Array.Sort(letters);
        Dictionary<char, int> result = CompareSequence(letters);
        foreach (var pair in result)
        {
            Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
        }
    }

    static Dictionary<char, int> CompareSequence(char[] letters)
    {
        Dictionary<char, int> result = new Dictionary<char, int>();
        for (int i = 0; i < letters.Length; i++)
        {
            char letter = letters[i];
            if (!result.ContainsKey(letter))
            {
                result.Add(letter, 1);
            }
            else
            {
                result[letter]++;
            }
        }
        return result;
    }
}
