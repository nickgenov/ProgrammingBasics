using System;

class OddAndEvenJumps
{
    static void Main()
    {
        //parse the input
        string input = Console.ReadLine();
        int oddJump = int.Parse(Console.ReadLine());
        int evenJump = int.Parse(Console.ReadLine());

        //remove spaces from the input string
        string[] arrayInput = input.Split(' ');
        string inputLower = string.Empty;
        for (int index = 0; index < arrayInput.Length; index++)
        {
            inputLower += arrayInput[index];
        }
        //set the input string to lower case
        inputLower = inputLower.ToLower();

        //set up variables for odd and even letters
        string oddLetters = string.Empty;
        string evenLetters = string.Empty;

        //assemble the new strings
        for (int index = 0; index < inputLower.Length; index++)
        {
            if (index % 2 == 0)
            {
                oddLetters += inputLower[index];
            }
            else
            {
                evenLetters += inputLower[index];
            }
        }
        //use the method for the odd and even strings
        long oddResult = CalculateResult(oddLetters, oddJump);
        long evenResult = CalculateResult(evenLetters, evenJump);
        //print the solution
        Console.WriteLine("Odd: {0:X}", oddResult);
        Console.WriteLine("Even: {0:X}", evenResult);
    }
    //method for calculating the jump result
    public static long CalculateResult(string word, int jump)
    {
        long value = 0;
        int counter = 1;
        for (int index = 0; index < word.Length; index++)
        {
            if (counter % jump == 0)
            {
                value *= word[index];
            }
            else
            {
                value += word[index];
            }
            counter++;
        }
        return value;
    }
}