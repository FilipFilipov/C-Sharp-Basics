using System;
using System.Collections.Generic;

class JoinLists
{
    static void Main()
    {
        List<int> numbersList = new List<int>();
        uint listsEntered = 0;
        while (listsEntered < 2)
        {
            Console.WriteLine("Enter {0} list of integers, separated by a space:", listsEntered < 1 ? "first" : "second");
            string[] input = Console.ReadLine().Split(' ');
            for (int i = 0; i < input.Length; i++)
            {
                int currentNum = int.Parse(input[i]);
                if (!numbersList.Contains(currentNum))
                {
                    numbersList.Add(currentNum);
                }
            }
            listsEntered++;
        }
        numbersList.Sort();
        Console.WriteLine("Final list:");
        foreach (var number in numbersList)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}
