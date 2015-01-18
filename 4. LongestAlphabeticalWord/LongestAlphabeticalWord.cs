using System;
using System.Text;

class LongestAlphabeticalWord
{
    static void Main()
    {
        string word = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());
        char[,] array = new char[n, n];
        //fill array with the letters of the word
        int i = 0;
        for (int row = 0; row < array.GetLength(0); row++)
        {
            for (int col = 0; col < array.GetLength(1); col++)
            {
                if (i < word.Length)
                {
                    array[row, col] = word[i];
                }
                else
                {
                    i = 0;
                    array[row, col] = word[i];
                }
                i++;
            }
        }
        //print array to test
        for (int row = 0; row < array.GetLength(0); row++)
        {
            for (int col = 0; col < array.GetLength(1); col++)
            {
                //Console.Write("{0} ", array[row, col]);
            }
            //Console.WriteLine();
        }
        //if the array size is 1:
        if (n == 1)
        {
            Console.WriteLine(array[0, 0]);
            return;
        }
        //set up variables
        StringBuilder currentBuild = new StringBuilder();
        string longest = string.Empty;
        //check rows from left to right
        for (int row = 0; row < array.GetLength(0); row++)
        {
            for (int col = 0; col < array.GetLength(1) - 1; col++)
            {
                if (col == 0)
                {
                    currentBuild.Append(array[row, col]);
                }
                if (array[row, col] < array[row, col + 1])
                {
                    currentBuild.Append(array[row, col + 1]);
                }
                else
                {
                    currentBuild.Clear();
                    currentBuild.Append(array[row, col + 1]);
                }
                string current = currentBuild.ToString();
                //use method to check if the new word is the longest
                longest = ReturnEarlierWord(longest, current);
            }
            currentBuild.Clear();
        }
        //check rows from right to left
        for (int row = 0; row < array.GetLength(0); row++)
        {
            for (int col = array.GetLength(1) - 1; col > 0; col--)
            {
                if (col == array.GetLength(1) - 1)
                {
                    currentBuild.Append(array[row, col]);
                }
                if (array[row, col] < array[row, col - 1])
                {
                    currentBuild.Append(array[row, col - 1]);
                }
                else
                {
                    currentBuild.Clear();
                    currentBuild.Append(array[row, col - 1]);
                }
                string current = currentBuild.ToString();
                //use method to check if the new word is the longest
                longest = ReturnEarlierWord(longest, current);
            }
            currentBuild.Clear();
        }
        //check columns from top to bottom
        for (int col = 0; col < array.GetLength(1); col++)
        {
            for (int row = 0; row < array.GetLength(0) - 1; row++)
            {
                if (row == 0)
                {
                    currentBuild.Append(array[row, col]);
                }
                if (array[row, col] < array[row + 1, col])
                {
                    currentBuild.Append(array[row + 1, col]);
                }
                else
                {
                    currentBuild.Clear();
                    currentBuild.Append(array[row + 1, col]);
                }
                string current = currentBuild.ToString();
                //use method to check if the new word is the longest
                longest = ReturnEarlierWord(longest, current);
            }
            currentBuild.Clear();
        }
        //check columns from bottom to top
        for (int col = 0; col < array.GetLength(1); col++)
        {
            for (int row = array.GetLength(0) - 1; row > 0; row--)
            {
                if (row == array.GetLength(0) - 1)
                {
                    currentBuild.Append(array[row, col]);
                }
                if (array[row, col] < array[row - 1, col])
                {
                    currentBuild.Append(array[row - 1, col]);
                }
                else
                {
                    currentBuild.Clear();
                    currentBuild.Append(array[row - 1, col]);
                }
                string current = currentBuild.ToString();
                //use method to check if the new word is the longest
                longest = ReturnEarlierWord(longest, current);
            }
            currentBuild.Clear();
        }
        //print result!!!
        Console.WriteLine(longest);
    }
    public static string ReturnEarlierWord(string word1, string word2)
    {
        int lengthWord1 = word1.Length;
        int lengthWord2 = word2.Length;
        if (lengthWord1 > lengthWord2)
        {
            return word1;
        }
        else if (lengthWord2 > lengthWord1)
        {
            return word2;
        }
        else if (lengthWord1 == lengthWord2)
        {
            for (int i = 0; i < word1.Length; i++)
            {
                if (word1[i] < word2[i])
                {
                    return word1;
                }
                else if (word2[i] < word1[i])
                {
                    return word2;
                }
            }
        }
        return word1;
    }
}