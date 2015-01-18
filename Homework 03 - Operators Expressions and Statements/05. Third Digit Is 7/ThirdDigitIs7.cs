using System;

class ThirdDigitIs7
{
    static void Main()
    {
        Console.Write("Enter an integer to check if the 3rd digit is 7: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine((a / 100 % 10) == 7);
    }
}