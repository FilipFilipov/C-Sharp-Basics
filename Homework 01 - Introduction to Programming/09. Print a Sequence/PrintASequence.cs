﻿using System;

class PrintASequence
{
    static void Main()
    {
        int num = 3;
        Console.Write(2);
        for (int i = 0; i < 10; i++)
        {
            Console.Write(", {0}", num);
            if (num > 0)
            {
                num = (num * (-1)) - 1;
            }
            else
            {
                num = (num * (-1)) + 1;
            }
        }
        Console.WriteLine();
    }
}
