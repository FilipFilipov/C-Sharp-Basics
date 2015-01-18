using System;

class QuotesInStrings
{
    static void Main()
    {
        string unquoted = "The \"use\" of quotations causes difficulties.";
        string quoted = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine("{0}\n{1}", unquoted, quoted);
    }
}
