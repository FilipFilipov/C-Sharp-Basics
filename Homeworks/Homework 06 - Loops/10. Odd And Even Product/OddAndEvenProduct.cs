using System;

class OddAndEvenProduct
{
    static void Main()
    {
        Console.WriteLine("Enter Integers, separated by a space:");
        string [] input = Console.ReadLine().Split(' ');
        int[] numbers = new int[input.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(input[i]);
        }
        long oddProduct = 1;
        long evenProduct = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (i % 2 == 0)
            {
                oddProduct *= numbers[i];
            }
            else
            {
                evenProduct *= numbers[i];
            }
        }
        if (oddProduct == evenProduct)
        {
            Console.WriteLine("yes\nproduct = {0}", oddProduct);
        }
        else
        {
            Console.WriteLine("no\nodd_product = {0}\neven_product = {1}",
                oddProduct, evenProduct);
        }
    }
}
