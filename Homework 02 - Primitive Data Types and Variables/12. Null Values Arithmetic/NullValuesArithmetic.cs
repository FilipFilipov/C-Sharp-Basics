using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? a = null;
        double? b = null;
        Console.WriteLine("a = {0}\nb = {1}", a, b);
        a += 5;
        b += 10.0;
        Console.WriteLine();
        Console.WriteLine("Adding to null:");
        Console.WriteLine("a = {0}\nb = {1}", a, b);
    }
}
