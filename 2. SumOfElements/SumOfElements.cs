using System;

class SumOfElements
{
    static void Main()
    {
        //parse the input string
        string input = Console.ReadLine();
        //split the string to an array of integers with the method
        long[] numbers = SplitStringToNumbers(input);
        //calculate the sum of all numbers
        long sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];

        }
        //set up variables
        bool validResult = false;
        long result = 0;
        long minDiff = long.MaxValue;
        //check all numbers in the array
        for (int i = 0; i < numbers.Length; i++)
        {
            //equal case
            if (numbers[i] == sum - numbers[i])
            {
                validResult = true;
                result = numbers[i];
                break;
            }
            //diff case
            long diff = Math.Abs(numbers[i] - (sum - numbers[i]));
            if (diff < minDiff)
            {
                //update the minimal difference
                minDiff = diff;
            }
        }
        //display result on the console
        if (validResult)
        {
            Console.WriteLine("Yes, sum={0}", result);
        }
        else
        {
            Console.WriteLine("No, diff={0}", minDiff);
        }
    }
    //method for splitting a string to an array of integers
    public static long[] SplitStringToNumbers(string input)
    {
        string[] strings = input.Split(' ');
        long[] numbers = new long[strings.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = long.Parse(strings[i]);
        }
        return numbers;
    }
}