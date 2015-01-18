using System;

class TripleRotationOfDigits
{
    //Telerik Academy Exam 1 @ 29 Dec 2012
    //Problem 1 – Triple Rotation of Digits
    static void Main()
    {
        //parse input
        int number = int.Parse(Console.ReadLine());

        //rotate digits 3 times
        int result = number;
        for (int i = 0; i < 3; i++)
        {
            //get the last digit
            int lastDigit = result % 10;
            //use the method to calculate the meaning digits count
            int digitsCount = CountDecimalDigits(result);

            //shift the number right 1 decimal position
            result /= 10;
            //add the value of the last digit to the first position
            result += lastDigit * (int)Math.Pow(10, digitsCount - 1);
        }
        //print the result
        Console.WriteLine(result);
    }
    public static int CountDecimalDigits(int number)
    {
        int count = 0;
        while (number > 0)
        {
            number /= 10;
            count++;
        }
        return count;
    }
}