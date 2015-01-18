using System;

class SumOf5Numbers
{
    static void Main()
    {
        double sum = 0;
        Console.Write("Enter 5 numbers, separated by spaces: ");
        string[] input = Console.ReadLine().Split(' ');
        for (int i = 0; i < 5; i++)
        {
            double CurrentNumber = double.Parse(input[i]);
            sum += CurrentNumber;
        }
        Console.WriteLine("{0}", sum);
    }
}
