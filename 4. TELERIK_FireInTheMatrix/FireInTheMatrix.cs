using System;

class FireInTheMatrix
{
    //Telerik Academy Exam 1 @ 23 June 2013
    //Problem 4 – Fire in the Matrix
    static void Main()
    {
        //parse input
        int n = int.Parse(Console.ReadLine());

        //top half
        int dotCount = (n / 2) - 1;
        int middleDotCount = 0;
        while (dotCount >= 0)
        {
            Console.WriteLine(new string('.', dotCount) + '#' + new string('.', middleDotCount) + '#' + new string('.', dotCount));
            dotCount--;
            middleDotCount += 2;
        }
        dotCount = 0;
        middleDotCount = n - 2;
        while (middleDotCount >= n / 2)
        {
            Console.WriteLine(new string('.', dotCount) + '#' + new string('.', middleDotCount) + '#' + new string('.', dotCount));
            dotCount++;
            middleDotCount -= 2;
        }
        //line
        Console.WriteLine(new string('-', n));
        //bottom half
        dotCount = 0;
        int dashCount = n / 2;
        while (dashCount >= 1)
        {
            Console.WriteLine(new string('.', dotCount) + new string('\\', dashCount) + new string('/', dashCount) + new string('.', dotCount));
            dotCount++;
            dashCount--;
        }
    }
}