using System;

class HalfSum
{
    static void Main()
    {
        //parse the count of numbers
        int count = int.Parse(Console.ReadLine());
        //set up variables for counting each set
        int sumFirstHalf = 0;
        int sumSecondHalf = 0;
        //loop count times to parse all the numbers
        for (int index = 1; index <= 2 * count; index++)
        {
            int number = int.Parse(Console.ReadLine());
            //add to the first sum
            if (index <= count)
            {
                sumFirstHalf += number;
            }
            //add to the second sum
            else
            {
                sumSecondHalf += number;
            }
        }
        //print the result
        if (sumFirstHalf == sumSecondHalf)
        {
            Console.WriteLine("Yes, sum={0}", sumFirstHalf);
        }
        else
        {
            //calculate the difference between sums
            int difference = Math.Abs(sumFirstHalf - sumSecondHalf);
            Console.WriteLine("No, diff={0}", difference);
        }
    }
}