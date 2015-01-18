using System;

class DecimalToBinaryNumber
{
    static void Main()
    {
	    Console.Write("Write an integer in decimal: ");
        long decimalNumber = long.Parse(Console.ReadLine());        
        string binaryInReverse = "";
        if (decimalNumber == 0)
        {
            binaryInReverse = "0";
        }   
        while (decimalNumber != 0)
        {
            long bit = decimalNumber % 2;
            if (bit == 0)
            {
                binaryInReverse += 0;
            }
            else
            {
                binaryInReverse += 1;
            }
            decimalNumber /= 2;
        }
        char[] binary = binaryInReverse.ToCharArray();
        Array.Reverse(binary);
        Console.Write("Your number in binary is: ");
        foreach (var bit in binary)
        {
            Console.Write(bit);
        }
        Console.WriteLine();
    }
}
