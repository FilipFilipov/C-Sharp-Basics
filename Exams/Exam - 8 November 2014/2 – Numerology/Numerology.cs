using System;

class Numerology
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        DateTime birthday = DateTime.ParseExact(input[0], "dd.MM.yyyy", null);
        long celestialNumber = birthday.Day * birthday.Month * birthday.Year;
        if (birthday.Month % 2 == 1)
        {
            celestialNumber *= celestialNumber;
        }
        foreach (var ch in input[1])
        {
            if (ch >= '0' && ch <= '9')
            {
                celestialNumber += ch - '0';
            }
            else if (ch >= 'A' && ch <= 'Z')
            {
                celestialNumber += (ch - 'A' + 1) * 2;
            }
            else
            {
                celestialNumber += ch - 'a' + 1;
            }
        }
        while (celestialNumber > 13)
        {
            long sum = 0;
            while (celestialNumber > 0)
            {
                sum += celestialNumber % 10;
                celestialNumber /= 10;
            }
            celestialNumber = sum;
        }
        Console.WriteLine(celestialNumber);       
     }
}
