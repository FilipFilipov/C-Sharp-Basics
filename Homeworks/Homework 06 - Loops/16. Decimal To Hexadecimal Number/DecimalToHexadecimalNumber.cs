using System;

class DecimalToHexadecimalNumber
{
    static void Main()
    {
        Console.Write("Write an integer in decimal: ");
        long decimalNumber = long.Parse(Console.ReadLine());
        string hexInReverse = "";
        if (decimalNumber == 0)
        {
            hexInReverse = "0";
        }
        while (decimalNumber != 0)
        {
            long hexNumber = decimalNumber % 16;
            switch (hexNumber)
            {
                case 10:
                    hexInReverse += 'A';
                    break;
                case 11:
                    hexInReverse += 'B';
                    break;
                case 12:
                    hexInReverse += 'C';
                    break;
                case 13:
                    hexInReverse += 'D';
                    break;
                case 14:
                    hexInReverse += 'E';
                    break;
                case 15:
                    hexInReverse += 'F';
                    break;
                default:
                    hexInReverse += hexNumber.ToString();
                    break;
            }
            decimalNumber /= 16;
        }
        char[] hex = hexInReverse.ToCharArray();
        Array.Reverse(hex);
        Console.Write("Your number in hexadecimal is: ");
        foreach (char number in hex)
        {
            Console.Write(number);
        }
        Console.WriteLine();
    }
}
