﻿using System;

class SumOf3Numbers
{
    static void Main()
    {
        Console.WriteLine("Please enter the three numbers:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("Sum = " + (a + b + c));
    }
}
