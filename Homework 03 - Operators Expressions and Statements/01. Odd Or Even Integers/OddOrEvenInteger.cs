using System;

class OddOrEvenInteger
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine((a % 2 == 0) ? "Number is odd." : "Number is even.");
    }
}
