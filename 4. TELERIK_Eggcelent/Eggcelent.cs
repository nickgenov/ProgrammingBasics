using System;

class Eggcelent
{
    //Telerik Academy Exam 1 @ 5 December 2013 Evening
    //Problem 4 - Eggcelent
    static void Main()
    {
        //parse input
        int n = int.Parse(Console.ReadLine());

        //first row
        Console.WriteLine(new string('.', n + 1) + new string('*', n - 1) + new string('.', n + 1));
        //top half
        int rows = n - 2;
        int rowCount = 0;
        int dotCount = n - 1;
        int middleDotCount = n + 1;
        while (dotCount >= 1)
        {
            if (n > 2)
            {
                Console.WriteLine(new string('.', dotCount) + '*' + new string('.', middleDotCount) + '*' + new string('.', dotCount));
            }
            dotCount -= 2;
            middleDotCount += 4;
            rowCount++;
        }
        middleDotCount = (3 * n) - 3;
        int middleRowsCount = 0;
        while (rowCount < rows)
        {
            Console.WriteLine("" + '.' + '*' + new string('.', middleDotCount) + '*' + '.');
            rowCount++;
            middleRowsCount++;
        }
        //middle 2 rows
        Console.WriteLine("" + '.' + '*' + ReturnFirstRow(n) + '*' + '.');
        Console.WriteLine("" + '.' + '*' + ReturnSecondRow(n) + '*' + '.');
        //bottom half
        rowCount = 0;
        while (rowCount < middleRowsCount)
        {
            Console.WriteLine("" + '.' + '*' + new string('.', middleDotCount) + '*' + '.');
            rowCount++;
        }
        dotCount = 1;
        middleDotCount = (3 * n) - 3;
        while (middleDotCount >= (n + 1))
        {
            if (n > 2)
            {
                Console.WriteLine(new string('.', dotCount) + '*' + new string('.', middleDotCount) + '*' + new string('.', dotCount));
            }
            dotCount += 2;
            middleDotCount -= 4;
        }
        //last row
        Console.WriteLine(new string('.', n + 1) + new string('*', n - 1) + new string('.', n + 1));
    }
    public static string ReturnFirstRow(int n)
    {
        int count = (3 * n) - 3;
        string result = "";
        for (int i = 1; i <= count; i++)
        {
            if (i % 2 == 1)
            {
                result += '@';
            }
            else
            {
                result += '.';
            }
        }
        return result;
    }
    public static string ReturnSecondRow(int n)
    {
        int count = (3 * n) - 3;
        string result = "";
        for (int i = 1; i <= count; i++)
        {
            if (i % 2 == 1)
            {
                result += '.';
            }
            else
            {
                result += '@';
            }
        }
        return result;
    }
}