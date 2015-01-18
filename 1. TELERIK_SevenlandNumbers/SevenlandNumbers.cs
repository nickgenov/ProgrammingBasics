using System;

class SevenlandNumbers
{
    //Telerik Academy Exam 1 @ 28 Dec 2012
    //Problem 1 – Sevenland Numbers
    static void Main()
    {
        //parse the seven base number
        int number = int.Parse(Console.ReadLine());

        int firstDigit = (number / 100) % 10;
        int secondDigit = (number / 10) % 10;
        int thirdDigit = (number / 1) % 10;

        int zeroDigit = 0;

        if (thirdDigit == 6)
        {
            thirdDigit = 0;
            if (secondDigit == 6)
            {
                secondDigit = 0;
                if (firstDigit == 6)
                {
                    firstDigit = 0;
                    zeroDigit = 1;
                }
                else
                {
                    firstDigit++;
                }
            }
            else
            {
                secondDigit++;
            }
        }
        else
        {
            thirdDigit++;
        }
        string result = "" + zeroDigit + firstDigit + secondDigit + thirdDigit;
        Console.WriteLine(int.Parse(result));
    }
    //unused methods
    public static int CountNumberDigits(int number)
    {
        int count = 0;
        while (number > 0)
        {
            number /= 10;
            count++;
        }
        return count;
    }
    public static int[] DigitsToArray(int number)
    {
        int digitsCount = CountNumberDigits(number);
        int[] digits = new int[digitsCount];
        for (int i = digitsCount - 1; i >= 0; i--)
        {
            digits[i] = number % 10;
            number /= 10;
        }
        return digits;
    }
}