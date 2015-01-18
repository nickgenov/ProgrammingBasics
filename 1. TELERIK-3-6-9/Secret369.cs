using System;

class Secret369
{
    //Telerik Academy Exam 1 @ 6 December 2013 Morning
    //Problem 1 – 3-6-9
    static void Main()
    {
        //parse input
        long a = long.Parse(Console.ReadLine());
        long b = long.Parse(Console.ReadLine());
        long c = long.Parse(Console.ReadLine());

        //variable to store the result
        long result = 0;

        //check each case for the secret code b
        if (b == 3)
        {
            result = a + c;
        }
        else if (b == 6)
        {
            result = a * c;
        }
        else if (b == 9)
        {
            result = a % c;
        }

        //variable for the first line of the output
        long firstLine = 0;
        //calculate it's value
        if (result % 3 == 0)
        {
            firstLine = result / 3;
        }
        else
        {
            firstLine = result % 3;
        }

        //print the result on the console
        Console.WriteLine(firstLine);
        Console.WriteLine(result);
    }
}