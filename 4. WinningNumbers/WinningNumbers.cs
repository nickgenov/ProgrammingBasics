using System;

class WinningNumbers
{
    static void Main()
    {
        //parse input string
        string input = Console.ReadLine();
        //use the method to calculate the sum of letters in the string
        int letSum = ReturnWordValue(input);
        //check if there is a solution
        bool validSolution = false;
        //loop through all numbers 000 000 - 999 999
        for (int a = 0; a <= 9; a++)
        {
            for (int b = 0; b <= 9; b++)
            {
                for (int c = 0; c <= 9; c++)
                {
                    for (int d = 0; d <= 9; d++)
                    {
                        for (int e = 0; e <= 9; e++)
                        {
                            for (int f = 0; f <= 9; f++)
                            {
                                //calculate the product of the first and second half
                                int productABC = a * b * c;
                                int productDEF = d * e * f;
                                //check if the number is a winning one
                                bool winningNumber = (productABC == productDEF) && (productDEF == letSum);
                                //display the number
                                if (winningNumber)
                                {
                                    validSolution = true;
                                    Console.WriteLine("{0}{1}{2}-{3}{4}{5}", a, b, c, d, e, f);
                                }
                            }
                        }
                    }
                }
            }
        }
        //if no solution was found
        if (!validSolution)
        {
            Console.WriteLine("No");
        }
    }
    public static int ReturnCharValue(char letter)
    {
        int value = 0;
        if (letter >= 65 && letter <= 90)
        {
            value = letter - 64;
        }
        else if (letter >= 97 && letter <= 122)
        {
            value = letter - 96;
        }
        return value;
    }
    public static int ReturnWordValue(string word)
    {
        int value = 0;
        for (int i = 0; i < word.Length; i++)
        {
            value += ReturnCharValue(word[i]);
        }
        return value;
    }
}