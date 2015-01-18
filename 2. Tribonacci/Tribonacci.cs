using System;
using System.Numerics;

class Tribonacci
{
    static void Main()
    {
        //parse the first three elements of the Tribonacci sequence
        BigInteger first = BigInteger.Parse(Console.ReadLine());
        BigInteger second = BigInteger.Parse(Console.ReadLine());
        BigInteger third = BigInteger.Parse(Console.ReadLine());
        //the n-th member we have to find
        int n = int.Parse(Console.ReadLine());

        //if n < 3
        if (n == 1)
        {
            Console.WriteLine(first);
        }
        else if (n == 2)
        {
            Console.WriteLine(second);
        }
        else if (n == 3)
        {
            Console.WriteLine(third);
        }
        else if (n > 3)
        {
            BigInteger element = 0;
            //start from the third element
            int count = 3;
            // < n because we increase the counter next
            while (count < n)
            {
                element = first + second + third;
                first = second;
                second = third;
                third = element;
                count++;
            }
            Console.WriteLine(element);
        }
    }
}