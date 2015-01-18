using System;
using System.Collections.Generic;

class RemoveNames
{
    static void Main()
    {        
        Console.WriteLine("Enter a list of names, separated by a space:");        
        string[] currentList = Console.ReadLine().Split(' ');
        List<string> names = new List<string>();
        names.AddRange(currentList);
        Console.WriteLine("Enter names to remove from the list, separated by a space:");
        currentList = Console.ReadLine().Split(' ');
        for (int i = 0; i < currentList.Length; i++)
        {
            while (names.Contains(currentList[i]))
            {
                names.Remove(currentList[i]);
            }
        }
        Console.WriteLine("Final list:");
        foreach (var name in names)
        {
            Console.Write(name + " ");
        }
        Console.WriteLine();
    }
}
