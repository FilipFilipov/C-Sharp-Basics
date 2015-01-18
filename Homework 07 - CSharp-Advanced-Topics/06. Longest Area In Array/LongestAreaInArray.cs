using System;

class LongestAreaInArray
{
    static void Main()
    {
        Console.Write("How many strings do you want to enter? ");
        uint n = uint.Parse(Console.ReadLine());
        string[] stringsToCheck = new string[n];
        Console.WriteLine("Enter string(s):");
        for (int i = 0; i < n; i++)
        {            
            stringsToCheck[i] = Console.ReadLine();
        }
        CompareSequence(stringsToCheck);
    }

    static void CompareSequence(string[] stringsToCheck)
    {
        uint longestSequence = 0;
        uint sequenceLength = 1;
        string element = "";
        for (uint i = 0; i < stringsToCheck.Length - 1; i++)
        {
            if (stringsToCheck[i] == stringsToCheck[i + 1])
            {
                sequenceLength++;                
            }
            else
            {
                sequenceLength = 1;
            }
            if (sequenceLength > longestSequence)
            {
                longestSequence = sequenceLength;
                element = stringsToCheck[i];
            }
        }
        Console.WriteLine();
        Console.WriteLine(longestSequence);
        for (int i = 0; i < longestSequence; i++)
        {
            Console.WriteLine(element);
        }        
    }
}
