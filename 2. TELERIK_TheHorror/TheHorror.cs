using System;

class TheHorror
{
    //Telerik Academy Exam 1 @ 6 December 2013 Morning
    //Problem 2 – The Horror
    static void Main()
    {
        //parse input
        string input = Console.ReadLine();
        //variable for storing the sum of digits
        long digitSum = 0;
        //the count of digits at even positions
        long digitCount = 0;

        //go through all positions in the text
        for (int i = 0; i < input.Length; i++)
        {
            bool isDigit = CheckIsDigit(input[i]);
            if ((i % 2 == 0) && isDigit)
            {
                digitSum += long.Parse(Convert.ToString(input[i]));
                digitCount++;
            }
        }
        //print the result
        Console.WriteLine("{0} {1}", digitCount, digitSum);
    }
    public static bool CheckIsDigit(char character)
    {
        bool characterIsDigit = false;
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
            case '9': characterIsDigit = true;
                break;
        }
        return characterIsDigit;
    }
}