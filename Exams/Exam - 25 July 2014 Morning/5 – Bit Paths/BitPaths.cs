using System;

class BitPaths
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] board = new int[8];
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(',');
            int start = int.Parse(input[0]);
            int mask = 1 << (3 - start);
            board[0] ^= mask;
            int path;
            for (int j = 1; j < 8; j++)
            {
                path = int.Parse(input[j]);
                if (path == -1)
                {
                    mask <<= 1;
                }
                else if (path == 1)
                {
                    mask >>= 1;
                }
                board[j] ^= mask;
            }
        }
        int sum = 0;
        foreach (var num in board)
        {
            sum += num;
        }
        Console.WriteLine(Convert.ToString(sum, 2));
        Console.WriteLine("{0:X}", sum);
    }
}
