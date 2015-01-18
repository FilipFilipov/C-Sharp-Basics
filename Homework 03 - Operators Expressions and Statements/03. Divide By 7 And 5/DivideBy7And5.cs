using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter an integer to check if it can be divided by 5 and 7: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine(a % 5 == 0 && a % 7 == 0);
    }
}
