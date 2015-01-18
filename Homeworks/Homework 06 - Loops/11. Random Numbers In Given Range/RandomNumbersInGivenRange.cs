using System;

class RandomNumbersInGivenRange
{
    static void Main()
    {
        Random rnd = new Random();
        Console.Write("How many numbers do you want? ");
        uint n = uint.Parse(Console.ReadLine());
        Console.Write("Enter lower limit: ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Enter upper limit: ");
        int max = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(rnd.Next(min, max + 1));
        }
    }
}
