using System;

class MultiplicationSign
{
    static void Main()
    {
        Console.WriteLine("Enter three numbers to see product sign:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        int negatives = 0;
        if (a == 0 || b == 0 || c == 0)
            Console.WriteLine("Product is 0");
        else
        {
            if (a < 0)
            {
                negatives++;
            }
            if (b < 0)
            {
                negatives++;
            }
            if (c < 0)
            {
                negatives++;
            }
            bool evenNegatives = (negatives % 2) == 0;
            Console.Write("Product sign is ");
            Console.WriteLine(evenNegatives ? "+" : "-");
        }
    }
}