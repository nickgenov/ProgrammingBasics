using System;
using System.Numerics;
using System.Text;

class TheSecretsOfNumbers
{
    //Telerik Academy Exam 1 @ 24 June 2013 Evening
    //Problem 2 – The Secrets of Numbers
    static void Main()
    {
        //parse input
        BigInteger number = BigInteger.Parse(Console.ReadLine());

        //calculate the special sum with the method
        BigInteger specialSum = CalculateSpecialSum(number);

        //the length of the special alpha-sequence
        int alphaSequenceLength = (int)(specialSum % 10);
        int remainder = (int)(specialSum % 26);

        //first letter in the alpha sequence
        int firstLetter = remainder + 1;

        //assemble the alpha sequence
        StringBuilder sequence = new StringBuilder();
        //add the ASCII code of (A - 1) to the code of the first letter
        int letter = firstLetter + 64;
        for (int count = 0; count < alphaSequenceLength; count++)
        {
            if (letter > 90)
            {
                letter = 65;
            }
            sequence.Append((char)letter);
            letter++;
        }
        string alphaSequence = sequence.ToString();

        //print the result
        Console.WriteLine(specialSum);
        if (alphaSequenceLength == 0)
        {
            Console.WriteLine("{0} has no secret alpha-sequence", number);
        }
        else
        {
            Console.WriteLine(alphaSequence);
        }
    }
    public static BigInteger CalculateSpecialSum(BigInteger number)
    {
        BigInteger specialSum = 0;
        //loop for a maximum of 400 digits in the input number
        for (int digitPosition = 1; digitPosition <= 400; digitPosition++)
        {
            //IMPORTANT to get the absolute value, the number may be negative!
            int digitValue = Math.Abs((int)(number % 10));
            number /= 10;

            if (digitPosition % 2 == 0)
            {
                specialSum += digitValue * digitValue * digitPosition;
            }
            else
            {
                specialSum += digitValue * digitPosition * digitPosition;
            }
        }
        return specialSum;
    }
}