using System;

class KaspichaniaBoats
{
    //Telerik Academy Exam 1 @ 6 December 2013 Evening
    //Problem 4 - Kaspichania Boats
    static void Main()
    {
        //parse input
        int n = int.Parse(Console.ReadLine());
        //total number of rows to be printed
        int rows = 6 + ((n - 3) / 2) * 3;
        //row counter
        int rowCount = 0;

        //first line
        Console.WriteLine(new string('.', n) + '*' + new string('.', n));
        rowCount++;
        //sails
        int startDots = n - 1;
        int middleDots = 0;
        while (startDots >= 1)
        {
            Console.WriteLine(new string('.', startDots) + '*' + new string('.', middleDots)  + '*' + new string('.', middleDots) + '*' + new string('.', startDots));
            startDots--;
            middleDots++;
            rowCount++;
        }
        //deck line
        Console.WriteLine(new string('*', (2 * n + 1)));
        rowCount++;
        //base
        startDots = 1;
        middleDots = n - 2;
        while (rowCount < rows - 1)
        {
            Console.WriteLine(new string('.', startDots) + '*' + new string('.', middleDots) + '*' + new string('.', middleDots) + '*' + new string('.', startDots));
            startDots++;
            middleDots--;
            rowCount++;
        }
        //last line
        Console.WriteLine(new string('.', startDots) + new string('*', n) + new string('.', startDots));
    }
}