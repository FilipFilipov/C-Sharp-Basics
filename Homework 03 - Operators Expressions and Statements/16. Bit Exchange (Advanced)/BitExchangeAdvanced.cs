using System;

class BitExchangeAdvanced
{
    static void Main()
    {
        Console.Write("Enter an unsigned integer: ");
        uint input = uint.Parse(Console.ReadLine());
        int p, q, k;
        while (true)
        {
            Console.Write("Enter first bit swap position: ");
            p = int.Parse(Console.ReadLine());
            if (p < 0 || p > 31)
            {
                Console.WriteLine("Bit index out of range!");
                continue;
            }
            while (true)
            {
                Console.Write("Enter second bit swap position: ");
                q = int.Parse(Console.ReadLine());
                if (q < 0 || q > 31)
                {
                    Console.WriteLine("Bit index out of range!");
                    continue;
                }
                while (true)
                {
                    Console.Write("Enter swap sequence length: ");
                    k = int.Parse(Console.ReadLine());
                    if (k < 1 || k > 31 || (Math.Max(p, q) + k - 1) > 31)
                    {
                        Console.WriteLine("Bit index(es) out of range!");
                        continue;
                    }
                    else if ((Math.Min(p, q) + k) >= Math.Max(p, q))
                    {
                        Console.WriteLine("Overlapping bit sequences!");
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                break;
            }
            break;
        }
        uint mask = 0;
        for (int i = 1; i < k; i++)
        {
            mask |= 1;
            mask <<= 1;
        }
        uint bits_p_k = (input >> p) & mask;
        uint bits_q_k = (input >> q) & mask;
        uint inputZeros = input & (~(mask << p)) & (~(mask << q));
        uint result = inputZeros | (bits_p_k << q) | (bits_q_k << p);
        Console.WriteLine("{0} => {1}", input, result);
    }
}