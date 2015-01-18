using System;

class MorseCodeNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        bool morse = false;
        while (n > 0)
        {
            sum += n % 10;
            n /= 10;
        }
        string[] morseCodes = { "-----|", ".----|", "..---|", "...--|", "....-|", ".....|" };
        for (int d1 = 1; d1 < 6; d1++)
        {
            for (int d2 = 1; d2 < 6; d2++)
            {
                for (int d3 = 1; d3 < 6; d3++)
                {
                    for (int d4 = 1; d4 < 6; d4++)
                    {
                        for (int d5 = 1; d5 < 6; d5++)
                        {
                            for (int d6 = 1; d6 < 6; d6++)
                            {
                                int product = d1 * d2 * d3 * d4 * d5 * d6;
                                if (product == sum)
                                {
                                    morse = true;
                                    Console.WriteLine(morseCodes[d1] + morseCodes[d2] + morseCodes[d3] +
                                        morseCodes[d4] + morseCodes[d5] + morseCodes[d6]);
                                }
                            }
                        }
                    }
                }
            }
        }
        if (!morse)
        {
            Console.WriteLine("No");
        }
    }
}
