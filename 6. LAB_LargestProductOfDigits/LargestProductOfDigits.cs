using System;
using System.Numerics;

class LargestProductOfDigits
{
    static void Main()
    {
        //parse the number
        string input = Console.ReadLine();
        BigInteger num = BigInteger.Parse(input);
        //store the digits in an array
        int[] digits = new int[input.Length];
        for (int i = input.Length - 1; i >= 0; i--)
        {
            digits[i] = (int)(num % 10);
            num /= 10;
        }
        //set up variables for algorithm
        int product = 1;
        int largestProduct = 0;
        //this is the key part of the solution
        //start from the first digit, count 6
        //then start from the second digit, count 6
        int index = 0;
        while (index <= digits.Length - 6)
        {
            for (int count = 0; count < 6; count++)
            {
                product *= digits[index + count];
                //only compare when all the digits have been multiplied!
                //if one of them is 0, the product is 0
                if (product > largestProduct && count == 5)
                {
                    largestProduct = product;
                }
            }
            //reset the product for the next set of 6 digits
            product = 1;
            //increase the index to get the product of the next 6 digits
            index++;
        }
        Console.WriteLine(largestProduct);
    }
}

