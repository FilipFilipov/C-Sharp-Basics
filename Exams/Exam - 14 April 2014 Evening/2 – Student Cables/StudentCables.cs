using System;

class StudentCables
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        long totalLength = 3;
        for (int i = 0; i < n; i++)
        {
            int cable = int.Parse(Console.ReadLine());
            string measure = Console.ReadLine();
            if (measure == "meters")
            {
                cable *= 100;
            }
            if (cable >= 20)
            {
                totalLength += cable - 3;
            }
        }
        Console.WriteLine(totalLength / 504);
        Console.WriteLine(totalLength % 504);
    }
}
