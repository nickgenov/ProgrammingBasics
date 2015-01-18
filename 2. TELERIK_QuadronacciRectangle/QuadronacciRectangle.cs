using System;

class QuadronacciRectangle
{
    //Telerik Academy Exam 1 @ 29 Dec 2012
    //Problem 2 – Quadronacci Rectangle
    static void Main()
    {
        long first = long.Parse(Console.ReadLine());
        long second = long.Parse(Console.ReadLine());
        long third = long.Parse(Console.ReadLine());
        long fourth = long.Parse(Console.ReadLine());

        int rows = int.Parse(Console.ReadLine());
        int columns = int.Parse(Console.ReadLine());

        int element = 1;

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < columns; col++)
            {
                long quadronacci = ReturnQuadronacci(first, second, third, fourth, element);
                if (col < columns - 1)
                {
                    Console.Write("{0} ", quadronacci);
                }
                else
                {
                    Console.WriteLine("{0}", quadronacci);
                }
                element++;
            }
        }
    }
    public static long ReturnQuadronacci(long first, long second, long third, long fourth, int element)
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
        else if (element == 4)
        {
            return fourth;
        }
        else
        {
            long quadronacci = 0;
            for (int i = 5; i <= element; i++)
            {
                quadronacci = first + second + third + fourth;
                first = second;
                second = third;
                third = fourth;
                fourth = quadronacci;
            }
            return quadronacci;
        }
    }
}