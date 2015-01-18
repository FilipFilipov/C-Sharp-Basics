using System;

class Sort3NumbersWithNestedIfs
{
    static void Main()
    {
        Console.WriteLine("Enter three numbers to sort:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        if (a <= b)
        {
            if (a <= c)
            {
                if (b <= c)
                {
                    Console.WriteLine(c + " " + b + " " + a);
                }
                else
                {
                    Console.WriteLine(b + " " + c + " " + a);
                }
            }
            else
            {
                if (a <= b)
                {
                    Console.WriteLine(b + " " + a + " " + c);
                }
                else
                {
                    Console.WriteLine(a + " " + b + " " + c);
                }
            }
        }
        else
        {
            if (a <= c)
            {
                Console.WriteLine(c + " " + a + " " + b);
            }
            else
            {
                Console.WriteLine(a + " " + c + " " + b);
            }
        }
    }
}
