using System;

class BiggestTriple
{
    static void Main()
    {
        string [] input = Console.ReadLine().Split(' ');
        int biggestSum = int.MinValue;
        int tripletNumber = 0;
        int biggestTriplet = 0;
        int sum = 0;
        for (int i = 0; i < input.Length; i++)
        {
            sum += int.Parse(input[i]);
            if (i % 3 == 0)
            {
                tripletNumber++;
            }
            if ((i + 1) % 3 == 0 || i == input.Length - 1)
            {
                if (sum > biggestSum)
                {
                    biggestSum = sum;
                    biggestTriplet = tripletNumber - 1;
                }
                sum = 0;
            }
        }
        for (int i = biggestTriplet * 3; i < (biggestTriplet + 1) * 3; i++)
        {
            Console.Write(input[i] + " ");
            if (i == input.Length - 1)
            {
                break;
            }
        }    
    }
}
