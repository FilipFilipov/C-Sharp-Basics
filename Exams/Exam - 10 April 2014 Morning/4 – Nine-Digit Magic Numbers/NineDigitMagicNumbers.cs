using System;

class NineDigitMagicNumbers
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
        bool magic = false;
        for (int i = 111; i <= 777 - (diff * 2); i++)
        {
            int abc = i;
            int def = abc + diff;
            int ghi = def + diff;
            int sum1, sum2, sum3;
            if (SumIfValid(abc, out sum1) && SumIfValid(def, out sum2) && SumIfValid(ghi, out sum3) && sum1 + sum2 + sum3 == sum)
            {
                magic = true;
                Console.WriteLine("{0}{1}{2}", abc, def, ghi);
            }
        }
        if (magic == false)
        {
            Console.WriteLine("No");
        }
    }

    private static bool SumIfValid(int number, out int sumN)
    {
        sumN = 0;
        while (number > 0)
        {
            int digit = number % 10;
            if (digit == 0 || digit > 7)
            {
                return false;
            }
            sumN += digit;
            number /= 10;
        }
        return true;
    }
}