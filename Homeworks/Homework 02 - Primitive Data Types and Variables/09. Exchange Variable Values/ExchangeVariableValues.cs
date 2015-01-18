using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("a = {0}\nb = {1}", a, b);
        a += b;
        b = a - b;
        a -= b;
        Console.WriteLine();
        Console.WriteLine("Value swapped");
        Console.WriteLine("a = {0}\nb = {1}", a, b);
    }
}
