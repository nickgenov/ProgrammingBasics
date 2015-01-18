using System;

class PeaceOfCake
{
    //Telerik Academy Exam 1 @ 5 December 2013 Evening
    //Problem 1 – Peace of Cake
    static void Main()
    {
        //parse input
        long a = long.Parse(Console.ReadLine());
        long b = long.Parse(Console.ReadLine());
        long c = long.Parse(Console.ReadLine());
        long d = long.Parse(Console.ReadLine());

        //the total number of cakes
        decimal totalCakes = (a / (b * 1.0M)) + (c / (d * 1.0M));
        //calculate fraction result
        long nominator = (a * d) + (b * c);
        long denominator = b * d;

        //two cases
        if (totalCakes >= 1)
        {
            //cut off the decimal part, we need
            //to print the amount of whole cakes
            totalCakes = (long)totalCakes;
            Console.WriteLine("{0}", totalCakes);
        }
        else
        {
            //print the decimal number with 22 digits
            //after the decimal point
            Console.WriteLine("{0:F22}", totalCakes);
        }
        //print the fraction result
        Console.WriteLine("{0}/{1}", nominator, denominator);
    }
}