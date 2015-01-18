using System;

class BinaryToDecimalNumber
{
    static void Main()
    {
        Console.Write("Write an integer in binary: ");
        string binary = Console.ReadLine();
        int baseNumber = 2;
        long power = 1;
        long decimalNumber = 0;
        for (int i = (binary.Length - 1); i >= 0; i--)
        {            
            int bit = int.Parse(binary[i].ToString());                
            decimalNumber += bit * power;
            power *= baseNumber;
        }
         Console.WriteLine("Your number in decimal is: {0}", decimalNumber);
    }
}
