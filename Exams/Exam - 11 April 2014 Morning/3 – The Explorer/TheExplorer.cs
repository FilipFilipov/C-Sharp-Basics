using System;

class TheExplorer
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int leftPosition = (n / 2) + 1;
        int rightPosition = (n / 2) + 1;
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                Console.Write((j == leftPosition) || (j == rightPosition) ? "*" : "-");
            }
            if (i < (n / 2) + 1)
            {
                leftPosition--;
                rightPosition++;
            }
            else
            {
                leftPosition++;
                rightPosition--;
            }
            Console.WriteLine();
        }
    }
}
