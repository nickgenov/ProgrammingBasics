using System;

class Secret248
{
    //Telerik Academy Exam 1 @ 6 December 2013 Evening
    //Problem 1 - 2-4-8
    static void Main()
    {
        //parse input
        ulong a = ulong.Parse(Console.ReadLine());
        ulong b = ulong.Parse(Console.ReadLine());
        ulong c = ulong.Parse(Console.ReadLine());

        //variable for the result
        ulong result = 0;

        //different cases depending on the secret code
        if (b == 2)
        {
            result = a % c;
        }
        else if (b == 4)
        {
            result = a + c;
        }
        else if (b == 8)
        {
            result = a * c;
        }

        //variable for the first line of the output
        ulong firstLine = 0;

        if (result % 4 == 0)
        {
            firstLine = result / 4;
        }
        else
        {
            firstLine = result % 4;
        }
        //print the final result
        Console.WriteLine(firstLine);
        Console.WriteLine(result);
    }
}