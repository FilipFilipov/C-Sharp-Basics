using System;
using System.Text;

class IsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        string unicode = "\u00A9";
        Console.WriteLine("{0}", unicode.PadLeft(4));
        Console.WriteLine("{0} {1}", unicode.PadLeft(3), unicode);
        Console.WriteLine("{0}   {1}", unicode.PadLeft(2), unicode);
        Console.WriteLine("{0} {0} {0} {0}", unicode);
    }
}
