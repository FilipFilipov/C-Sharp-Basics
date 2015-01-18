using System;
using System.Text;

class NumberAsWords
{
    static void Main()
    {
        uint number;
        while (true)
        {
            Console.Write("Type an integer number between 0 and 999: ");
            if (uint.TryParse(Console.ReadLine(), out number) && (number < 1000))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
        string result = getWord(number);
        Console.WriteLine("Your number is \"{0}\".", char.ToUpper(result[0]) + result.Substring(1));
    }

    private static string getWord(uint number)
    {
        StringBuilder word = new StringBuilder();
        if (number < 20)
        {
            switch (number)
            {
                case 0:
                    word.Append("zero"); break;
                case 1:
                    word.Append("one"); break;
                case 2:
                    word.Append("two"); break;
                case 3:
                    word.Append("three"); break;
                case 4:
                    word.Append("four"); break;
                case 5:
                    word.Append("five"); break;
                case 6:
                    word.Append("six"); break;
                case 7:
                    word.Append("seven"); break;
                case 8:
                    word.Append("eight"); break;
                case 9:
                    word.Append("nine"); break;
                case 10:
                    word.Append("ten"); break;
                case 11:
                    word.Append("eleven"); break;
                case 12:
                    word.Append("twelve"); break;
                case 13:
                    word.Append("thirteen"); break;
                case 14:
                    word.Append("fourteen"); break;
                case 15:
                    word.Append("fifteen"); break;
                case 16:
                    word.Append("sixteen"); break;
                case 17:
                    word.Append("seventeen"); break;
                case 18:
                    word.Append("eightteen"); break;
                case 19:
                    word.Append("nineteen"); break;
                default:
                    word.Append(""); break;
            }
        }
        else if (number < 100)
        {
            switch (number / 10)
            {
                case 2:
                    word.Append("twenty"); break;
                case 3:
                    word.Append("thirty"); break;
                case 4:
                    word.Append("fourty"); break;
                case 5:
                    word.Append("fifty"); break;
                case 6:
                    word.Append("sixty"); break;
                case 7:
                    word.Append("seventy"); break;
                case 8:
                    word.Append("eighty"); break;
                case 9:
                    word.Append("ninety"); break;
                default:
                    word.Append(""); break;
            }            
            string ones = getWord(number % 10);
            word.Append(" " + ones);
        }
        else
        {
            string hundreds = getWord(number / 100);            
            string rest = getWord(number % 100);
            word.Append(hundreds);
            word.Append(" hundred");
            if (rest != "zero")
            {
                word.Append(" and " + rest);
            }
        }
        return word.ToString();
    }
}
