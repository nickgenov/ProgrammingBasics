using System;

class AngryFemaleGPS
{
    //Telerik Academy Exam 1 @ 5 December 2013 Evening
    //Problem 2 – Angry Female GPS
    static void Main()
    {
        //parse the input number as a string
        string input = Console.ReadLine();

        //variables for each sum
        long sumEvenDigits = 0;
        long sumOddDigits = 0;

        //go through each digit
        for (int i = 0; i < input.Length; i++)
        {
            //check for white that can cause exception
            bool isDigit = CheckIsDigit(input[i]);
            if (isDigit)
            {
                //convert the chars in the string to int
                long digit = long.Parse(Convert.ToString(input[i]));
                //even or odd case
                if (digit % 2 == 0)
                {
                    sumEvenDigits += digit;
                }
                else
                {
                    sumOddDigits += digit;
                }
            }
        }
        //print the result
        if (sumEvenDigits > sumOddDigits)
        {
            Console.WriteLine("right {0}", sumEvenDigits);
        }
        else if (sumOddDigits > sumEvenDigits)
        {
            Console.WriteLine("left {0}", sumOddDigits);
        }
        else if (sumOddDigits == sumEvenDigits)
        {
            Console.WriteLine("straight {0}", sumOddDigits);
        }
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