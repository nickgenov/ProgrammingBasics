using System;

class Tables
{
    static void Main()
    {
        //parse input
        long bundle1 = long.Parse(Console.ReadLine());
        long bundle2 = long.Parse(Console.ReadLine());
        long bundle3 = long.Parse(Console.ReadLine());
        long bundle4 = long.Parse(Console.ReadLine());
        long tops = long.Parse(Console.ReadLine());
        long tablesToMake = long.Parse(Console.ReadLine());

        //legs in all bundles
        long legs = bundle1 + (bundle2 * 2) + (bundle3 * 3) + (bundle4 * 4);
        //how many tables we can make
        long tablesMade = Math.Min(legs / 4, tops);

        long topsDifference = Math.Abs(tablesToMake - tablesMade);
        long legsDifference = Math.Abs((tablesToMake * 4) - legs);

        //three cases
        if (tablesMade == tablesToMake)
        {
            Console.WriteLine("Just enough tables made: {0}", tablesMade);
        }
        else if (tablesMade < tablesToMake)
        {
            //calculate how many legs are needed
            //if we have more legs than we need, the output is 0
            long legsNeeded = 0;
            if (tablesToMake * 4 > legs)
            {
                legsNeeded = (tablesToMake * 4) - legs;
            }
            Console.WriteLine("less: {0}", tablesMade - tablesToMake);
            Console.WriteLine("tops needed: {0}, legs needed: {1}", topsDifference, legsNeeded);
        }
        else if (tablesMade > tablesToMake)
        {
            Console.WriteLine("more: {0}", tablesMade - tablesToMake);
            Console.WriteLine("tops left: {0}, legs left: {1}", topsDifference, legsDifference);
        }
    }
}