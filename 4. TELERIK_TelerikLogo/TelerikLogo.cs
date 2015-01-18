using System;

class TelerikLogo
{
    //Telerik Academy Exam 1 @ 28 Dec 2012
    //Problem 4 – Telerik Logo
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        //first line
        int startDotCount = n / 2;
        //calculate the middle dot count, key part of the solution!
        int middleDotCount = 1;
        for (int count = 0; count < n - 2; count++)
        {
            middleDotCount += 2;
        }
        Console.WriteLine(new string('.', startDotCount) + '*' + new string('.', middleDotCount) + '*' + new string('.', startDotCount));
        //top symbol
        startDotCount--;
        middleDotCount -= 2;
        int dotCount = 1;
        while (startDotCount >= 0)
        {
            Console.WriteLine(new string('.', startDotCount) + '*' + new string('.', dotCount) + '*' + new string('.', middleDotCount) + '*' + new string('.', dotCount) + '*' + new string('.', startDotCount));
            startDotCount--;
            dotCount += 2;
            middleDotCount -= 2;
        }
        //top symbol end
        while (middleDotCount >= 1)
        {
            Console.WriteLine(new string('.', dotCount) + '*' + new string('.', middleDotCount) + '*' + new string('.', dotCount));
            dotCount++;
            middleDotCount -= 2;
        }
        //rhomb first line
        Console.WriteLine(new string('.', dotCount) + '*' + new string('.', dotCount));
        //rhomb top half
        dotCount--;
        middleDotCount = 1;
        int rowCount = n - 1;
        while (rowCount > 1)
        {
            Console.WriteLine(new string('.', dotCount) + '*' + new string('.', middleDotCount) + '*' + new string('.', dotCount));
            dotCount--;
            middleDotCount += 2;
            rowCount--;
        }
        //rhomb bottom half
        while (middleDotCount >= 1)
        {
            Console.WriteLine(new string('.', dotCount) + '*' + new string('.', middleDotCount) + '*' + new string('.', dotCount));
            dotCount++;
            middleDotCount -= 2;
        }
        //last line
        Console.WriteLine(new string('.', dotCount) + '*' + new string('.', dotCount));
    }
}