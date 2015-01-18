using System;
using System.Collections.Generic;

class CountOfNames
{
    static void Main()
    {
        Console.WriteLine("Enter a list of names separated by a space:");
        string[] names = Console.ReadLine().Split(' ');
        Array.Sort(names);
        Dictionary<string, int> result = CompareSequence(names);
        foreach (var pair in result)
        {
            Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
        }
    }

    static Dictionary<string, int> CompareSequence(string[] names)
    {
        Dictionary<string, int> result = new Dictionary<string, int>();
        for (int i = 0; i < names.Length; i++)
        {
            string name = names[i];
            if (!result.ContainsKey(name))
            {
                result.Add(name, 1);
            }
            else
            {
                result[name]++;
            }
        }
        return result;
    }
}
