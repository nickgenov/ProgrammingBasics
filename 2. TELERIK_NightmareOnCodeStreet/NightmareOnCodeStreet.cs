using System;

class NightmareOnCodeStreet
{
    //Telerik Academy Exam 1 @ 6 December 2013 Evening
    //Problem 2 – Nightmare on Code Street
    static void Main()
    {
        string input = Console.ReadLine();

        //total amount of digits in odd positions
        long digitCount = 0;
        //sum of these digits
        long digitSum = 0;

        for (int i = 0; i < input.Length; i++)
        {
            bool condition = (i % 2 == 1) && IsDigit(input[i]);

            if (condition)
            {
                digitCount++;
                digitSum += int.Parse(Convert.ToString(input[i]));
            }
        }
        //print the result
        Console.WriteLine("{0} {1}", digitCount, digitSum);
    }
    //method to check if the symbol in the text is a digit
    public static bool IsDigit(char character)
    {
        bool CharacterIsDigit = false;
        switch (character)
        {
            case '0': 
            case '1': 
            case '2':
            case '3':
            case '4': 
            case '5': 
            case '6': 
            case '7': 
            case '8': 
            case '9': CharacterIsDigit = true;
                break;
        }
        return CharacterIsDigit;
    }
}