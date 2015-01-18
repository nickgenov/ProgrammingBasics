using System;

class DoubleDowns
{
    static void Main()
    {
        //parse the count of numbers
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        //store the numbers in an array
        for (int index = 0; index < n; index++)
        {
            numbers[index] = int.Parse(Console.ReadLine());
        }

        //variables for counting
        int verticalCouples = 0;
        int leftCouples = 0;
        int rightCouples = 0;
        //check all numbers in the array
        for (int index = 0; index < numbers.Length - 1; index++)
        {
            //calculate the vertical couples
            int verticalResult = numbers[index] & numbers[index + 1];
            verticalCouples += CountBits(verticalResult);
            //calculate the left-diagonal couples
            int leftResult = numbers[index] & (numbers[index + 1] >> 1);
            leftCouples += CountBits(leftResult);
            //calculate the right-diagonal couples
            int rightResult = (numbers[index] >> 1) & numbers[index + 1];
            rightCouples += CountBits(rightResult);
        }
        //display result
        Console.WriteLine(rightCouples);
        Console.WriteLine(leftCouples);
        Console.WriteLine(verticalCouples);
    }
    //method for counting the 1 bits in the binary representation of a number
    public static int CountBits(int number)
    {
        int count = 0;
        while (number > 0)
        {
            if (number % 2 == 1)
            {
                count++;
            }
            number /= 2;
        }
        return count;
    }
}