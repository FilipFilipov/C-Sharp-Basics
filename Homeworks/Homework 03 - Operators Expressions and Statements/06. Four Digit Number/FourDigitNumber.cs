using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.Write("Enter a 4-digit number: ");
        int a = int.Parse(Console.ReadLine());
        int firstDigit = a / 1000;
        int secondDigit = (a / 100) % 10;
        int thirdDigit = (a / 10) % 10;
        int fourthDigit = a % 10;
        int sum = firstDigit + secondDigit + thirdDigit + fourthDigit;
        int reverse = fourthDigit * 1000 + thirdDigit * 100 + secondDigit * 10 + firstDigit;
        int lastInFront = fourthDigit * 1000 + firstDigit * 100 + secondDigit * 10 + thirdDigit;
        int secondThirdExchanged = firstDigit * 1000 + thirdDigit * 100 + secondDigit * 10 + fourthDigit;
        Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", a, sum, reverse, lastInFront, secondThirdExchanged);
    }
}
