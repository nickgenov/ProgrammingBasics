using System;
using System.Numerics;

class TribonacciTriangle
{
    //Telerik Academy Exam 1 @ 27 Dec 2012
    //Problem 2 – Tribonacci Triangle
    static void Main()
    {
        long first = long.Parse(Console.ReadLine());
        long second = long.Parse(Console.ReadLine());
        long third = long.Parse(Console.ReadLine());

        int lineCount = int.Parse(Console.ReadLine());

        int numbersCount = 1;
        int element = 1;

        for (int row = 0; row < lineCount; row++)
        {
            for (int col = 0; col < numbersCount; col++)
            {
                long tribonacci = ReturnTribonacci(first, second, third, element);
                if (col + 1 == numbersCount)
                {
                    Console.Write("{0}", tribonacci);
                }
                else
                {
                    Console.Write("{0} ", tribonacci);
                }
                element++;
            }
            numbersCount++;
            Console.WriteLine();
        }
    }
    public static long ReturnTribonacci(long first, long second, long third, int element)
    {
        long tribonacci = 0;
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
            for (int i = 4; i <= element ; i++)
            {
                tribonacci = first + second + third;
                first = second;
                second = third;
                third = tribonacci;
            }
            return tribonacci;
        }
    }
}