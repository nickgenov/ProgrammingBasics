using System;

class Headphones
{
    static void Main()
    {
        //parse input
        int n = int.Parse(Console.ReadLine());

        //first row
        int dashCount = n / 2;
        int starCount = n + 2;
        Console.WriteLine(new string('-', dashCount) + new string('*', starCount) + new string('-', dashCount));
        //cables
        int rows = n;
        int middleDashCount = n;
        while (rows > 0)
        {
            Console.WriteLine(new string('-', dashCount) + '*' + new string('-', middleDashCount) + '*' + new string('-', dashCount));
            rows--;
        }
        //headphones top half
        dashCount = (n / 2) - 1;
        middleDashCount = n - 2;
        starCount = 3;
        while (middleDashCount >= 1)
        {
            Console.WriteLine(new string('-', dashCount) + new string('*', starCount) + new string('-', middleDashCount) + new string('*', starCount) + new string('-', dashCount));
            dashCount--;
            starCount += 2;
            middleDashCount -= 2;
        }
        //headphones bottom half
        dashCount = 1;
        middleDashCount = 3;
        starCount = n - 2;
        while (middleDashCount <= n)
        {
            Console.WriteLine(new string('-', dashCount) + new string('*', starCount) + new string('-', middleDashCount) + new string('*', starCount) + new string('-', dashCount));
            dashCount++;
            starCount -= 2;
            middleDashCount += 2;
        }
    }
}