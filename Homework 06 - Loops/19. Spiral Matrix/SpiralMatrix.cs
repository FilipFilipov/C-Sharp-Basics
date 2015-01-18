using System;

class SpiralMatrix
{
    static void Main()
    {
        Console.Write("Enter a positive integer between 1 and 20: ");
        int n = int.Parse(Console.ReadLine());
        int [,] matrix = new int [n, n];
        int positionX = 0;
        int positionY = 0;
        int direction = 0;
        int stepsCount = n;
        int stepPosition = 1;
        bool oddCorner = true;
        for (int i = 1; i <= n * n; i++)
        {
            matrix[positionY, positionX] = i;
            if (stepPosition < stepsCount)
            {
                stepPosition++; 
            }
            else
            {
                stepPosition = 1;
                if (oddCorner)
                {
                    stepsCount--;
                }
                oddCorner = !oddCorner;
                direction++;
            }
            switch (direction % 4)
            {
                case 0:
                    positionX++;
                    break;
                case 1:
                    positionY++;
                    break;
                case 2:
                    positionX--;
                    break;
                case 3:
                    positionY--;
                    break;
            }
        }
        int spacer = 4;
        if (n < 10)
        {
            spacer = 3;
        }
        if (n < 4)
        {
            spacer = 2;
        }
        Console.WriteLine();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j].ToString().PadRight(spacer, ' '));
            }
            Console.WriteLine("\n");
        }
    }
}
