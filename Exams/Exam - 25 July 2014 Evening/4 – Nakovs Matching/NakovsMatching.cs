using System;

class NakovsMatching
{
    static void Main()
    {
        string first = Console.ReadLine();
        string second = Console.ReadLine();
        int limit = int.Parse(Console.ReadLine());
        bool matches = false;
        for (int i = 1; i < first.Length; i++)
        {
            string firstLeft = first.Substring(0, i);
            string firstRight = first.Substring(i);
            for (int j = 1; j < second.Length; j++)
            {
                string secondLeft = second.Substring(0, j);
                string secondRight = second.Substring(j);
                long distance = Math.Abs(
                    GetWeight(firstLeft) * GetWeight(secondRight) -
                    GetWeight(firstRight) * GetWeight(secondLeft));
                if (distance <= limit)
                {
                    Console.WriteLine("({0}|{1}) matches ({2}|{3}) by {4} nakovs",
                        firstLeft, firstRight, secondLeft, secondRight, distance);
                    matches = true;
                }
            }
        }
        if (!matches)
        {
            Console.WriteLine("No");
        }
    }

    private static long GetWeight(string seq)
    {
        long weight = 0;
        for (int i = 0; i < seq.Length; i++)
        {
            weight += seq[i];
        }
        return weight;
    }
}
