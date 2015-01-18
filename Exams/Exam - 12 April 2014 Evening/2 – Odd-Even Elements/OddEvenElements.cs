using System;

class OddEvenElements
{
    static void Main()
    {
        string input = Console.ReadLine();
        if (input == "")
        {
            Console.WriteLine("OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No");
            return;
        }
        string[] numbers = input.Split(' ');
        decimal oddMin = 1000000;
        decimal oddMax = -1000000;
        decimal oddSum = 0;
        decimal evenMin = 1000000;
        decimal evenMax = -1000000;
        decimal evenSum = 0;
        bool odd = true;
        for (int i = 0; i < numbers.Length; i++)
        {
            decimal currentNumber = decimal.Parse(numbers[i]);
            if (odd)
            {                
                oddSum += currentNumber;
                oddMin = Math.Min(currentNumber, oddMin);
                oddMax = Math.Max(currentNumber, oddMax);                
            }
            else
            {
                evenSum += currentNumber;
                evenMin = Math.Min(currentNumber, evenMin);
                evenMax = Math.Max(currentNumber, evenMax);
            }
            odd = !odd;            
        }
        if (numbers.Length == 1)
        {
            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum=No, EvenMin=No, EvenMax=No",
                (double)oddSum, (double)oddMin, (double)oddMax);
        }
        else
        {
            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}",
                (double)oddSum, (double)oddMin, (double)oddMax, (double)evenSum, (double)evenMin, (double)evenMax);
        }        
    }
}
