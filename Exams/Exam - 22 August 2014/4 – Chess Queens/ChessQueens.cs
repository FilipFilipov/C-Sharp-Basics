using System;

class ChessQueens
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        bool validPosition = false;
        for (char x1 = 'a'; x1 < 'a' + n; x1++)
        {
            for (int y1 = 1; y1 <= n; y1++)
            {
                for (char x2 = 'a'; x2 < 'a' + n; x2++)
                {
                    for (int y2 = 1; y2 <= n; y2++)
                    {
                        bool RightDeltaX = Math.Abs(x1 - x2) == d + 1;
                        bool RightDeltaY = Math.Abs(y1 - y2) == d + 1;
                        if ((x1 == x2 && RightDeltaY) || (y1 == y2 && RightDeltaX) || (RightDeltaX && RightDeltaY))
                        {
                            validPosition = true;
                            Console.WriteLine("{0}{1} - {2}{3}", x1, y1, x2, y2);
                        }
                    }
                }
            }   
        }
        if (!validPosition)
        {
            Console.WriteLine("No valid positions");
        }
    }
}
