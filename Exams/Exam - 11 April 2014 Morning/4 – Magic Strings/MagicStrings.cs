using System;
using System.Text;

class MagicStrings
{
    static void Main()
    {
        int diff = int.Parse(Console.ReadLine());
        StringBuilder abcd = new StringBuilder();
        StringBuilder efgh = new StringBuilder();
        char [] letters = { 'k', 'n', 'p', 's' };
        bool magic = false;
        for (int l1 = 0; l1 < letters.Length; l1++)
        {
            for (int l2 = 0; l2 < letters.Length; l2++)
            {
                for (int l3 = 0; l3 < letters.Length; l3++)
                {
                    for (int l4 = 0; l4 < letters.Length; l4++)
                    {
                        for (int l5 = 0; l5 < letters.Length; l5++)
                        {
                            for (int l6 = 0; l6 < letters.Length; l6++)
                            {
                                for (int l7 = 0; l7 < letters.Length; l7++)
                                {
                                    for (int l8 = 0; l8 < letters.Length; l8++)
                                    {
                                        abcd.Append(letters[l1]).Append(letters[l2]).Append(letters[l3]).Append(letters[l4]);
                                        efgh.Append(letters[l5]).Append(letters[l6]).Append(letters[l7]).Append(letters[l8]);                                       
                                        if (Math.Abs(CalculateWeight(abcd) - CalculateWeight(efgh)) == diff)
                                        {
                                            Console.WriteLine(abcd.ToString() + efgh.ToString());
                                            magic = true;
                                        }
                                        abcd.Clear();
                                        efgh.Clear();
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        if (!magic)
        {
            Console.WriteLine("No");
        }
    }

    private static int CalculateWeight (StringBuilder str)
    {
        int weight = 0;
        for (int i = 0; i < str.Length; i++)
        {
            switch (str[i])
            {
                case 'k':
                    weight += 1; break;
                case 'n':
                    weight += 4; break;
                case 'p':
                    weight += 5; break;
                case 's':
                    weight += 3; break;
            }
        }
        return weight;
    }
}
