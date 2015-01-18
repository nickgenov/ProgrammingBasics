using System;
using System.Numerics;

class CrossingSequences
{
    static void Main()
    {
        //parse tribonacci input
        long first = long.Parse(Console.ReadLine());
        long second = long.Parse(Console.ReadLine());
        long third = long.Parse(Console.ReadLine());
        //parse spiral sequence input
        long start = long.Parse(Console.ReadLine());
        long startStep = long.Parse(Console.ReadLine());

        //use this to check if a solution was found
        bool validSolution = false;

        //sequences initial values
        long tribonacci = 0;
        long spiral = 0;

        //loop through all combinations
        for (long count = 1; count < 1000; count++)
        {
            //calculate the tribonacci element with a method
            tribonacci = ReturnTribonacci(first, second, third, count);
            if (tribonacci > 1000000)
            {
                //exit the outer loop if the limit is reached
                break;
            }
            for (int spiralCount = 1; spiralCount < 2000; spiralCount++)
            {
                //calculate the spiral element with a method
                spiral = ReturnSpiral(start, startStep, spiralCount);
                //leave the inner loop if the limit is reached
                //or if the element is greater than the tribonacci element, no point checking further
                //because the spiral sequence is increasing and no match will be found
                if (spiral > 1000000 && spiral > tribonacci)
                {
                    break;
                }
                //if a solution is found, print it and end the program
                if (tribonacci == spiral)
                {
                    validSolution = true;
                    Console.WriteLine(tribonacci);
                    return;
                }
            }
        }
        //if no solution was found
        if (!validSolution)
        {
            Console.WriteLine("No");
        }
    }
    public static long ReturnTribonacci(long first, long second, long third, long element)
    {
        if (element == 1)
        {
            return first;
        }
        else if (element == 2)
        {
            return second;
        }
        else if (element == 3)
        {
            return third;
        }
        else
        {
            long counter = 4;
            long tribonacci = 0;
            while (counter <= element)
            {
                tribonacci = first + second + third;
                first = second;
                second = third;
                third = tribonacci;
                counter++;
            }
            return tribonacci;
        }
    }
    public static long ReturnSpiral(long start, long startStep, long elementNum)
    {
        if (elementNum == 1)
        {
            return start;
        }
        else
        {
            long result = start;
            long step = startStep;
            int counter = 1;

            int elementCounter = 2;

            while (elementCounter <= elementNum)
            {
                result += step;
                counter++;
                if (counter % 3 == 0)
                {
                    step += startStep;
                    counter = 1;
                }
                elementCounter++;
            }
            return result;
        }
    }
}