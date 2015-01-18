using System;

class OddEvenElements
{
    static void Main()
    {
        //parse input as string
        string input = Console.ReadLine();
        //border case n = 0, empty input
        if (input == "")
        {
            Console.WriteLine("OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No");
            return;
        }
        //use the method to get an array of decimal numbers
        decimal[] numbers = SplitStringToNumbers(input);
        //border case with 1 number in the string
        if (numbers.Length == 1)
        {
            Console.WriteLine("OddSum={0}, OddMin={0}, OddMax={0}, EvenSum=No, EvenMin=No, EvenMax=No", (double)numbers[0]);
            return;
        }
        //variables for the odd and even numbers
        decimal oddSum = 0;
        decimal oddMin = decimal.MaxValue;
        decimal oddMax = decimal.MinValue;

        decimal evenSum = 0;
        decimal evenMin = decimal.MaxValue;
        decimal evenMax = decimal.MinValue;

        for (int i = 0; i < numbers.Length; i++)
        {
            //first element is odd
            if (i % 2 == 0)
            {
                oddSum += numbers[i];
                if (numbers[i] > oddMax)
                {
                    oddMax = numbers[i];
                }
                if (numbers[i] < oddMin)
                {
                    oddMin = numbers[i];
                }
            }
            //second is even
            else
            {
                evenSum += numbers[i];
                if (numbers[i] > evenMax)
                {
                    evenMax = numbers[i];
                }
                if (numbers[i] < evenMin)
                {
                    evenMin = numbers[i];
                }
            }
        }
        //display result, (double) cast removes trailing zeroes from decimal
        Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}", (double)oddSum, (double)oddMin, (double)oddMax, (double)evenSum, (double)evenMin, (double)evenMax);
    }
    //method for splitting the input to an array of numbers
    public static decimal[] SplitStringToNumbers(string input)
    {
        string[] array = input.Split(' ');
        decimal[] numbers = new decimal[array.Length];

        for (int index = 0; index < numbers.Length; index++)
        {
            numbers[index] = decimal.Parse(array[index]);
        }
        return numbers;
    }
}