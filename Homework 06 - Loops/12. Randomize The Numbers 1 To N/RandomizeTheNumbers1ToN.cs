using System;

class RandomizeTheNumbers1ToN
{
    static void Main()
    {
	    Console.Write("Enter upper limit of number range: ");
        int n = int.Parse(Console.ReadLine());
        int [] numbers = new int [n];
        for (int i = 0; i < n; i++)
        {
            numbers [i] = i + 1;
        }
        Random rnd = new Random();
        for (int i = (n - 1); i >= 0; i--)
        {
            int m = rnd.Next(i + 1);
            int temp = numbers[i];
            numbers[i] = numbers[m];
            numbers[m] = temp;
        }
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}
