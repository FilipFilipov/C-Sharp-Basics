using System;

class OddAndEvenJumps
{
    static void Main()
    {
        string input = Console.ReadLine().Replace(" ", "").ToLower();
        int oddJump = int.Parse(Console.ReadLine());
        int evenJump = int.Parse(Console.ReadLine());
        ulong oddResult = 0;
        ulong evenResult = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (i % 2 == 0)
            {
                if ((i / 2 + 1) % oddJump == 0)
                {
                    oddResult *= input[i];
                }
                else
                {
                    oddResult += input[i];
                }
            }
            else
            {
                if ((i / 2 + 1) % evenJump == 0)
                {
                    evenResult *= input[i];
                }
                else
                {
                    evenResult += input[i];
                }
            }
        }       
        Console.WriteLine("Odd: {0:X}\nEven: {1:X}", oddResult, evenResult);
    }
}
