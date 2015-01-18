using System;

class Disk
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int r = int.Parse(Console.ReadLine());
        for (int x = -(n / 2); x <= n / 2; x++)
        {
            for (int y = -(n / 2); y <= n / 2; y++)
            {
                double distance = Math.Sqrt(x * x + y * y);
                Console.Write(distance <= r ? '*' : '.');
            }
            Console.WriteLine();
        }
    }
}
