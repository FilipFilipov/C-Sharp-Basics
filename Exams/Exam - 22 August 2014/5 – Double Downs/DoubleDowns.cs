using System;

class DoubleDowns
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());        
        int leftDiagonal = 0;
        int rightDiagonal = 0;
        int vertical = 0;
        int currentNum = int.Parse(Console.ReadLine());
        for (int i = 0; i < n - 1; i++)
        {
            int nextNum = int.Parse(Console.ReadLine());
            for (int position = 0; position < 32; position++)
            {
                int bit = (currentNum >> position) & 1;
                if ((bit == 1 && ((nextNum >> position + 1) & 1) == 1))
                {
                    leftDiagonal++;
                }
                if ((bit == 1 && ((nextNum >> position - 1) & 1) == 1))
                {
                    rightDiagonal++;
                }
                if ((bit == 1 && ((nextNum >> position) & 1) == 1))
                {
                    vertical++;
                }
            }
            currentNum = nextNum;
        }
        Console.WriteLine("{0}\n{1}\n{2}", rightDiagonal, leftDiagonal, vertical);
    }
}
