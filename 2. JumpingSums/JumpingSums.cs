using System;
 
class JumpingSums
{
    static void Main()
    {
        //parse input
        string input = Console.ReadLine();
        int jumps = int.Parse(Console.ReadLine());
 
        //store the input string in an array
        long[] numbers = SplitStringToInt(input);
 
        //variables for the sums
        long maxSum = long.MinValue;
 
        //go through the array and calculate
        //the jump sum for each number
        for (int i = 0; i < numbers.Length; i++)
        {
            long index = i;
            long currentSum = numbers[index];
            for (int j = 0; j < jumps; j++)
            {
                index += numbers[index];
                if (index > numbers.Length - 1)
                {
                    index = index % numbers.Length;
                }

                currentSum += numbers[index];

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
            }
        }
        Console.WriteLine("max sum = {0}", maxSum);
    }
    public static long[] SplitStringToInt(string input)
    {
        string[] stringArray = input.Split(' ');
        long[] numbers = new long[stringArray.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = long.Parse(stringArray[i]);
        }
        return numbers;
    }
} 