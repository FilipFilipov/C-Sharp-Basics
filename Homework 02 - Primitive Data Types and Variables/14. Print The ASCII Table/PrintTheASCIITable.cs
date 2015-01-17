using System;
using System.Text;

class PrintTheASCIITable
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        for (int i = 31; i < 128; i++)
        {
            if (i == 31)
            {
                Console.WriteLine("0-31 -> non-printing control characters");
            }
            else if (i == 32)
            {
                Console.WriteLine(i + " -> " + "(space)");
            }
            else if (i == 127)
            {
                Console.WriteLine(i + " -> " + "(control character \"delete\")");
            }
            else
            {
                Console.WriteLine(i + " -> " + (char)(i));
            }
        }
        for (int i = 159; i < 256; i++)
        {
            if (i == 159)
            {
                Console.WriteLine("128-159 -> non-printing control characters");
            }
            else if (i == 160)
            {
                Console.WriteLine(i + " -> " + "(non-breaking space)");
            }
            else
            {
                Console.WriteLine(i + " -> " + (char)(i));
            }
        }
    }
}
