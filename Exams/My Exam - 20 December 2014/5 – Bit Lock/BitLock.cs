using System;

class BitLock
{
    static void Main()
    {
        int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        string[] order = Console.ReadLine().Split(' ');
        while (order[0] != "end")
        {
            if (order[0] == "check")
            {
                int col = int.Parse(order[1]);
                CountBits(numbers, col);
            }
            else
            {
                int row = int.Parse(order[0]);
                string direction = order[1];
                int rotations = int.Parse(order[2]) % 12;
                numbers[row] = RollBits(numbers, row, direction, rotations);
            }
            order = Console.ReadLine().Split(' ');
        }
        foreach (var num in numbers)
        {
            Console.Write(num + " ");
        }
    }

    private static void CountBits(int[] numbers, int col)
    {
        int count = 0;
        foreach (var num in numbers)
        {
            count += (num >> col) & 1;
        }
        Console.WriteLine(count);
    }

    private static int RollBits(int[] numbers, int row, string direction, int rotations)
    {
        int number = numbers[row];
        for (int i = 0; i < rotations; i++)
        {
            int borderBit = (direction == "left") ? ((number >> 11) & 1) : (number & 1);
            if (direction == "left")
            {
                number &= ~(1 << 11);
                number <<= 1;
            }
            else
            {
                number >>= 1;
            }
            if (borderBit == 1)
            {
                number |= (direction == "left") ? borderBit : (borderBit << 11);
            }
        }
        return number;
    }
}
