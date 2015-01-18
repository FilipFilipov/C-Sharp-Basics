using System;

class TicTacToePower
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int v = int.Parse(Console.ReadLine());
        int value = v + x + 3 * y;
        int power = 1 + x + 3 * y;
        Console.WriteLine((long)Math.Pow(value, power));
    }
}
