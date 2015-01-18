using System;
using System.Text;

class ExtractURLsFromText
{
    static void Main()
    {
        Console.WriteLine("Enter some text:");
        string[] words = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine();
        StringBuilder address = new StringBuilder();
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Contains("www.") || words[i].Contains("http://"))
            {
                address.Append(words[i]);
                if (address[address.Length - 1] == '.')
                {
                    address.Remove((address.Length - 1), 1);
                }
                Console.WriteLine(address);
                address.Clear();
            }
        }
    }
}
