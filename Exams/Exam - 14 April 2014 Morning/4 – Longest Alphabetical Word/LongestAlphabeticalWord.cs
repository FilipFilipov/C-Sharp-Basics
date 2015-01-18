using System;
using System.Text;

class LongestAlphabeticalWord
{
    static void Main()
    {
        string inputWord = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());
        string longestAlphaWord = "";
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                string strLeft = FindAlphabeticalWord(inputWord, n, row, col, -1, 0);
                longestAlphaWord = GetLongerWord(longestAlphaWord, strLeft);
                string strRight = FindAlphabeticalWord(inputWord, n, row, col, +1, 0);
                longestAlphaWord = GetLongerWord(longestAlphaWord, strRight);
                string strUp = FindAlphabeticalWord(inputWord, n, row, col, 0, -1);
                longestAlphaWord = GetLongerWord(longestAlphaWord, strUp);
                string strDown = FindAlphabeticalWord(inputWord, n, row, col, 0, +1);
                longestAlphaWord = GetLongerWord(longestAlphaWord, strDown);
            }
        }
        Console.WriteLine(longestAlphaWord);
    }

    private static string FindAlphabeticalWord(
        string inputWord, int n, int row, int col, int directionX, int directionY)
    {
        StringBuilder letters = new StringBuilder();
        char currentLetter = GetLetterAtPosition(inputWord, n, row, col);
        letters.Append(currentLetter);
        while (true)
        {
            col = col + directionX;
            row = row + directionY;
            if (row < 0 || row >= n || col < 0 || col >= n)
            {
                break;
            }
            char nextLetter = GetLetterAtPosition(inputWord, n, row, col);
            if (nextLetter <= currentLetter)
            {
                break;
            }
            letters.Append(nextLetter);
            currentLetter = nextLetter;
        }
        return letters.ToString();
    }

    private static char GetLetterAtPosition(string inputWord, int n, int row, int col)
    {
        return inputWord[(row * n + col) % inputWord.Length];
    }

    private static string GetLongerWord(string firstWord, string secondWord)
    {
        if ((firstWord.Length > secondWord.Length) ||
            ((firstWord.Length == secondWord.Length) && (firstWord.CompareTo(secondWord) < 0)))
        {
            return firstWord;
        }
        return secondWord;
    }
}
