using System;
using System.Collections.Generic;

class LongestNonDecreasingSubsequence
{
    static void Main()
    {
        Console.WriteLine("Enter some integers separated by a space:");
        string[] input = Console.ReadLine().Split(' ');
        int[] nums = new int[input.Length];
        for (int i = 0; i < nums.Length; i ++)
        {
            nums[i] = int.Parse(input[i]);
        }
        List<List<int>> activeLists = new List<List<int>>();
        int maxLenght = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            int currentNum = nums[i];
            bool smallest = true;
            int count = activeLists.Count;
            for (int j = 0; j < count; j++)
            {
                if (currentNum >= activeLists[j][activeLists[j].Count - 1])
                {
                    List<int> temp = new List<int>(activeLists[j]);
                    temp.Add(currentNum);
                    activeLists.Add(temp);
                    smallest = false;
                    if (activeLists[activeLists.Count - 1].Count > maxLenght)
                    {
                        maxLenght = activeLists[activeLists.Count - 1].Count;
                    }                   
                }
            }
            if (smallest)
            {
                activeLists.Add(new List<int> {currentNum});
            }
        }
        foreach (List<int> list in activeLists)
        {            
            if (list.Count == maxLenght)
            {
                Console.WriteLine("The longest non-decreasing subsequence is:");
                foreach (int num in list)
                { 
                    Console.Write(num + " "); 
                }                                    
                break;
            }
        }
        Console.WriteLine();
    }
}