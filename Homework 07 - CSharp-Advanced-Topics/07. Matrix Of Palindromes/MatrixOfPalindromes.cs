using System;

class MatrixOfPalindromes
{
    static void Main()
    {
        char baseChar = 'a';
        Console.Write("Enter number of rows: ");
        uint r = uint.Parse(Console.ReadLine());
        Console.Write("Enter number of columns: ");
        uint c = uint.Parse(Console.ReadLine());
        for (uint i = 1; i <= r; i++)
        {           
            for (uint j = 0; j < c; j++)
            {
                Console.Write("{0}{1}{0} ", baseChar, (char)(baseChar + j));
            }
            baseChar++;
            Console.WriteLine();
        }       
    }
}
