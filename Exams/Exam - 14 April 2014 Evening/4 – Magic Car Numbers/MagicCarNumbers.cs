using System;
using System.Text;

class MagicCarNumbers
{    
    static void Main()
    {
        int magicWeight = int.Parse(Console.ReadLine());
        char[] letters = { 'A', 'B', 'C', 'E', 'H', 'K', 'M', 'P', 'T', 'X' };
        StringBuilder carNum = new StringBuilder("CA");
        int count = 0;
        for (int l1 = 0; l1 < letters.Length; l1++)
        {
            for (int l2 = 0; l2 < letters.Length; l2++)
            {
                for (char a = '0'; a <= '9'; a++)
                {
                    carNum.Append(a, 4).Append(letters[l1]).Append(letters[l2]);
                    count += CheckCarNumber(carNum.ToString(), magicWeight);
                    carNum.Clear().Append("CA");
                    for (char b = '0'; b <= '9'; b++)
                    {
                        if (b != a)
                        {
                            carNum.Append(a, 3).Append(b).Append(letters[l1]).Append(letters[l2]);
                            count += CheckCarNumber(carNum.ToString(), magicWeight);
                            carNum.Clear().Append("CA");
                            carNum.Append(a).Append(b, 3).Append(letters[l1]).Append(letters[l2]);
                            count += CheckCarNumber(carNum.ToString(), magicWeight);
                            carNum.Clear().Append("CA");
                            carNum.Append(a, 2).Append(b, 2).Append(letters[l1]).Append(letters[l2]);
                            count += CheckCarNumber(carNum.ToString(), magicWeight);
                            carNum.Clear().Append("CA");
                            carNum.Append(a).Append(b).Append(a).Append(b).Append(letters[l1]).Append(letters[l2]);
                            count += CheckCarNumber(carNum.ToString(), magicWeight);
                            carNum.Clear().Append("CA");
                            carNum.Append(a).Append(b, 2).Append(a).Append(letters[l1]).Append(letters[l2]);
                            count += CheckCarNumber(carNum.ToString(), magicWeight);
                            carNum.Clear().Append("CA");
                        }
                    }
                }
            }
        }
        Console.WriteLine(count);
    }

    static int CheckCarNumber(string carNumber, int magicSum)
    {
        int weight = 0;
        foreach (var ch in carNumber)
        {
            weight += (ch >= '0' && ch <= '9') ? (ch - '0') : (10 * (ch - 'A' + 1));           
        }
        if (weight == magicSum)
        {
            return 1;
        }
        return 0;
    }
}
