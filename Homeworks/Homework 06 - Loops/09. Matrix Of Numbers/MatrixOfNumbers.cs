using System;

class MatrixOfNumbers
{
    static void Main()
    {
        Console.Write("Give a number between 1 and 20: ");
        uint n = uint.Parse(Console.ReadLine());           
        for (int row = 1; row <= n; row++)
        {
            for (int column = row; column <= (n + row - 1); column++)
            {
                if (n > 5)
                {
                    if (column < 10)
                    {
                        Console.Write(column + "  ");
                    }
                    else
                    {
                        Console.Write(column + " ");
                    }
                }
                else
                {
                    Console.Write(column + " ");
                }    
            }
            Console.WriteLine();
        }
    }
}
