using System;

class Car
{
    static void Main()
    {
        //parse input
        int n = int.Parse(Console.ReadLine());
        //first line
        Console.WriteLine(new string('.', n) + new string('*', n) + new string('.', n));
        //top
        int startDotCount = n - 1;
        int middleDotCount = n;
        int rowCount = (n / 2) - 1;
        while (rowCount > 0)
        {
            Console.WriteLine(new string('.', startDotCount) + '*' + new string('.', middleDotCount) + '*' + new string('.', startDotCount));
            startDotCount--;
            middleDotCount += 2;
            rowCount--;
        }
        //body start
        int starCount = (n / 2) + 1;
        middleDotCount = (3 * n) - 2 * ((n / 2) + 1);
        Console.WriteLine(new string('*', starCount) + new string('.', middleDotCount) + new string('*', starCount));
        //print body
        rowCount = (n / 2) - 2;
        middleDotCount = (3 * n) - 2;
        while (rowCount > 0)
        {
            Console.WriteLine('*' + new string('.', middleDotCount) + '*');
            rowCount--;
        }
        Console.WriteLine(new string('*', 3 * n));
        //tyres
        rowCount = (n / 2) - 2;
        startDotCount = n / 2;
        int tyreDotCount = (n / 2) - 1;
        middleDotCount = n - 2;
        while (rowCount > 0)
        {
            Console.WriteLine(new string('.', startDotCount) + '*' + new string('.', tyreDotCount) + '*' + new string('.', middleDotCount) + '*' + new string('.', tyreDotCount) + '*' + new string('.', startDotCount));
            rowCount--;
        }
        //end
        starCount = (n / 2) + 1;
        Console.WriteLine(new string('.', startDotCount) + new string('*', starCount) + new string('.', middleDotCount) + new string('*', starCount) + new string('.', startDotCount));
    }
}