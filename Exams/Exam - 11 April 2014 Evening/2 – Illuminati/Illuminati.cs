using System;

class Illuminati
{
    static void Main()
    {
        string line = Console.ReadLine().ToUpper();
        int vowels = 0;
        int sum = 0;
        foreach (char letter in line)
        {
            switch(letter)
            {
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                    vowels++;
                    sum += letter;
                    break;
            }
        }
        Console.WriteLine(vowels + "\n" + sum);
    }
}
