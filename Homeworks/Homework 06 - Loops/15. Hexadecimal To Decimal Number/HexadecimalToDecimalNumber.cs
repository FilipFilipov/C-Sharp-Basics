using System;

class HexadecimalToDecimalNumber
{
    static void Main()
    {
        Console.Write("Write an integer in hexadecimal: ");
        string hexNumber = Console.ReadLine().ToUpper();
        int baseNumber = 16;
        long power = 1;
        int hexChar;
        long decimalNumber = 0;
        for (int i = (hexNumber.Length - 1); i >= 0; i--)
        {
            switch (hexNumber[i])
            {
                case 'A':
                    hexChar = 10; break;
                case 'B':
                    hexChar = 11; break;
                case 'C':
                    hexChar = 12; break;
                case 'D':
                    hexChar = 13; break;
                case 'E':
                    hexChar = 14; break;
                case 'F':
                    hexChar = 15; break;
                default:
                    hexChar = hexNumber[i] - '0'; break;
            }
            decimalNumber += hexChar * power;
            power *= baseNumber;
        }
        Console.WriteLine("Your number in decimal is: {0}", decimalNumber);
    }
}
