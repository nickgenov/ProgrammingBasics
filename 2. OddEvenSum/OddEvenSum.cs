using System;

class OddEvenSum
{
    static void Main()
    {
        //parse the count of numbers
        int n = int.Parse(Console.ReadLine());
        //set up variables for the sums
        int oddSum = 0;
        int evenSum = 0;
        //loop n times to read all the numbers
        for (int count = 1; count <= (2 * n); count++)
        {
            //parse the numbers 
            int number = int.Parse(Console.ReadLine());
            //increase the odd sum
            if (count % 2 == 1)
            {
                oddSum += number;
            }
            //increase the even sum
            else
            {
                evenSum += number;
            }
        }
        //display result
        if (oddSum == evenSum)
        {
            Console.WriteLine("Yes, sum={0}", oddSum);
        }
        else
        {
            //calculate difference
            int difference = Math.Abs(oddSum - evenSum);
            Console.WriteLine("No, diff={0}", difference);
        }
    }
}