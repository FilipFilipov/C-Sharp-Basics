using System;

class SumOfNNumbers
{
    static void Main()
    {
        Console.Write("How many numbers do you want to sum? ");
        uint number = uint.Parse(Console.ReadLine());
        Console.WriteLine("Enter numbers on separate lines:");
        double currentNumber;
        double sum = 0;
        for (int i = 0; i < number; i++)
        {
            currentNumber = double.Parse(Console.ReadLine());
            sum += currentNumber;
        }
        Console.WriteLine("Sum = {0}", sum);
    }
}
