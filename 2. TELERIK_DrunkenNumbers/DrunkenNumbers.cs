using System;

class DrunkenNumbers
{
    //Telerik Academy Exam 1 @ 23 June 2013
    //Problem 2 – Drunken Numbers
    static void Main()
    {
        int roundsCount = int.Parse(Console.ReadLine());

        int beersM = 0;
        int beersV = 0;

        for (int i = 0; i < roundsCount; i++)
        {
            long num = long.Parse(Console.ReadLine());
            int[] digits = DigitsToArray(num);
            int digitsCount = CountDecimalDigits(num);
            if (digitsCount % 2 == 0)
            {
                for (int j = 0; j < digitsCount / 2; j++)
                {
                    beersM += digits[j];
                }
                for (int k = digitsCount / 2; k < digitsCount; k++)
                {
                    beersV += digits[k];
                }
            }
            else
            {
                for (int j = 0; j < (digitsCount / 2) + 1; j++)
                {
                    beersM += digits[j]; 
                }
                for (int k = digitsCount / 2; k < digitsCount; k++)
                {
                    beersV += digits[k];
                }
            }
        }
        if (beersM > beersV)
        {
            Console.WriteLine("M {0}", beersM - beersV);
        }
        else if (beersV > beersM)
        {
            Console.WriteLine("V {0}", beersV - beersM);
        }
        else
        {
            Console.WriteLine("No {0}", beersM + beersV);
        }
    }
    public static int CountDecimalDigits(long number)
    {
        int count = 0;
        number = Math.Abs(number);
        while (number > 0)
        {
            number /= 10;
            count++;
        }
        return count;
    }
    public static int[] DigitsToArray(long number)
    {
        number = Math.Abs(number);
        int count = CountDecimalDigits(number);
        int[] digits = new int[count];
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            digits[i] = (int)(number % 10);
            number /= 10;
        }
        return digits;
    }
}