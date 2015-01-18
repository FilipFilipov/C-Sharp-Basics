using System;

class BitBuilder
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        while (true)
        {
            int position;
            if (!int.TryParse(Console.ReadLine(), out position))
            {
                break;
            }
            string order = Console.ReadLine();
            switch (order)
            {
                case "flip":
                    number ^= 1 << position; break;
                case "insert":
                    number = InsertBit(number, position); break;
                case "remove":
                    number = RemoveBit(number, position); break;
            }
        }
        Console.WriteLine(number);
    }

    private static long RemoveBit(long number, int position)
    {
        long newNumber = 0;
        for (int i = 0; i < 63; i++)
        {
            long currentBit = (number >> i) & 1L;
            if (i != position && currentBit == 1)
            {
                newNumber |= (i < position) ? (currentBit << i) : (currentBit << (i - 1));
            }            
        }
        return newNumber;
    }

    private static long InsertBit(long number, int position)
    {
        long newNumber = 0;        
        for (int i = 0; i < 63; i++)
        {
            long currentBit = (number >> i) & 1L;
            if (currentBit == 1)
            {
                newNumber |= (i < position) ? (currentBit << i) : (currentBit << (i + 1));                
            }
        }
        newNumber |= 1L << position;
        return newNumber;
    }
}
