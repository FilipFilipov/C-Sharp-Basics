using System;

class SortingNumbers
{
    static void Main()
    {
        Console.Write("How many integers do you want to sort? ");
        uint n = uint.Parse(Console.ReadLine());
        int[] numbersToSort = new int[n];
        Console.WriteLine("Enter integer(s):");
        for (int i = 0; i < n; i++)
        {
            numbersToSort[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(numbersToSort);
        Console.WriteLine("Sorted numbers:");
        foreach (var number in numbersToSort)
        {
            Console.WriteLine(number);
        }
    }
}
