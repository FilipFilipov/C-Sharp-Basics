using System;

class CalculateExpression
{
    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("X = ");
        int x = int.Parse(Console.ReadLine());
        decimal factorial = 1;
        decimal power = 1;
        decimal sum = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            power *= x;
            sum += factorial / power;
        }
        Console.WriteLine("1 + 1!/X + ... + N!/X^N = {0:F5}", sum);
    }
}
