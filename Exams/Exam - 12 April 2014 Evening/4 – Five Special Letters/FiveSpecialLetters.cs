using System;
using System.Text;

class FiveSpecialLetters
{
    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        StringBuilder abcde = new StringBuilder();
        bool match = false;
        for (char i = 'a'; i <= 'e'; i++)
        {
            for (char j = 'a'; j <= 'e'; j++)
            {
                for (char k = 'a'; k <= 'e'; k++)
                {
                    for (char l = 'a'; l <= 'e'; l++)
                    {
                        for (char m = 'a'; m <= 'e'; m++)
                        {                           
                            abcde.Append(i).Append(j).Append(k).Append(l).Append(m);
                            int weight = CalculateWeight(abcde.ToString());
                            if (weight >= start && weight <= end)
                            {                                
                                Console.Write(abcde + " ");
                                match = true;
                            }
                            abcde.Clear();
                        }
                    }
                }
            }
        }
        if (!match)
        {
            Console.WriteLine("No");
        }
    }

    private static int CalculateWeight(string abcde)
    {
        int weight = 0;
        int index = 1;
        for (int i = 0; i < abcde.Length; i++)
        {
            char letter = abcde[i];
            if (abcde.IndexOf(letter) == i)
            {
                switch (letter)
                {
                    case 'a':
                        weight += (5 * index); break;
                    case 'b':
                        weight -= (12 * index); break;
                    case 'c':
                        weight += (47 * index); break;
                    case 'd':
                        weight += (7 * index); break;
                    case 'e':
                        weight -= (32 * index); break;
                }
                index++;
            }
        }
        return weight;
    }
}
