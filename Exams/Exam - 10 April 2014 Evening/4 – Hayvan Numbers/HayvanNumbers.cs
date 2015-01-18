using System;

class HayvanNumbers
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
        bool hayvan = false;
        for (int i = 555; i <= 999 - (2 * diff); i++)
        {
            int abc = i;
            int def = abc + diff;
            int ghi = def + diff;
            int sum1, sum2, sum3;
            if (SumIfValid(abc, out sum1) && SumIfValid(def, out sum2) && SumIfValid(ghi, out sum3) && sum1 + sum2 + sum3 == sum)
            {
                hayvan = true;
                Console.WriteLine("{0}{1}{2}", abc, def, ghi);
            }
        }
        if (!hayvan)
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
            if (digit < 5)
            {
                return false;
            }
            sumN += digit;
            number /= 10;
        }
        return true;
    }
}