using System;

class UKFlag
{
    //Telerik Academy Exam 1 @ 29 Dec 2012
    //Problem 4 – UK Flag
    static void Main()
    {
        //parse input
        int n = int.Parse(Console.ReadLine());
        //top half
        int dotCount = 0;
        int middleDotCount = ((n - 1) / 2) - 1;
        while (middleDotCount >= 0)
        {
            Console.WriteLine(new string('.', dotCount) + '\\' + new string('.', middleDotCount) + '|' + new string('.', middleDotCount) + '/' + new string('.', dotCount));
            dotCount++;
            middleDotCount--;
        }
        //middle line
        Console.WriteLine(new string('-', n / 2) + '*' + new string('-', n / 2));
        //bottom half
        dotCount = ((n - 1) / 2) - 1;
        middleDotCount = 0;
        while (dotCount >= 0)
        {
            Console.WriteLine(new string('.', dotCount) + '/' + new string('.', middleDotCount) + '|' + new string('.', middleDotCount) + '\\' + new string('.', dotCount));
            dotCount--;
            middleDotCount++;
        }
    }
}