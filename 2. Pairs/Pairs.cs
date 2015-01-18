using System;

class Pairs
{
    static void Main()
    {
        //parse the input string
        string input = Console.ReadLine();
        //split it to a numbers array with a method
        int[] numbers = SplitStringToNumbers(input);
        //border case - just 2 numbers
        if (numbers.Length == 2)
        {
            Console.WriteLine("Yes, value={0}", numbers[0] + numbers[1]);
            return;
        }
        //variables for the calculation
        int maxDiff = int.MinValue;
        bool samePairs = true;
        int pairValue = 0;
        //loop through all pairs
        for (int i = 0; i < numbers.Length - 2; i+=2)
        {
            int pairA = numbers[i] + numbers[i + 1];
            int pairB = numbers[i + 2] + numbers[i + 3];
            if (pairA != pairB)
            {
                //if just two pairs are different, the result is No
                samePairs = false;
                //calculate difference only if pairs are different
                int diff = Math.Abs(pairA - pairB);
                if (diff > maxDiff)
                {
                    //update the max difference
                    maxDiff = diff;
                }
            }
            else
            {
                //store pair value for the end result
                pairValue = pairA;
            }
        }
        //display the result
        if (samePairs)
        {
            Console.WriteLine("Yes, value={0}", pairValue);
        }
        else
        {
            Console.WriteLine("No, maxdiff={0}", maxDiff);
        }
    }
    //method for splitting a string to an integer array
    public static int[] SplitStringToNumbers(string input)
    {
        string[] array = input.Split(' ');
        int[] numbers = new int[array.Length];

        for (int index = 0; index < numbers.Length; index++)
        {
            numbers[index] = int.Parse(array[index]);
        }
        return numbers;
    }
}