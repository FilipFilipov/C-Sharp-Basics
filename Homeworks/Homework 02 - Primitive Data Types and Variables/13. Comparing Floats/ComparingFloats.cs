﻿using System;

class ComparingFloats
{
    static void Main() 
    {
        Console.WriteLine("Enter two floating point numbers on separate lines to check them for equality:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double esp = 0.000001;
        if (Math.Sign(a) != Math.Sign(b))
        {
            Console.WriteLine(false);
        }
        else
        {
            double diffrence = Math.Abs(a - b);
            Console.WriteLine((diffrence < esp));
        }
    }
}
