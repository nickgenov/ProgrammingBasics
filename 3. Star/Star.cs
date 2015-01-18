using System;

class Star
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        //first row
        Console.WriteLine(new string('.', n) + '*' + new string('.', n));
        //top hand
        int dotCount = n - 1;
        int middleDotCount = 1;
        while (middleDotCount <= n - 3)
        {
            Console.WriteLine(new string('.', dotCount) + '*' + new string('.', middleDotCount) + '*' + new string('.', dotCount));
            dotCount--;
            middleDotCount += 2;
        }
        //line - start of hands
        middleDotCount = n - 1;
        int starCount = ((2 * n + 1) - (n - 1)) / 2;
        Console.WriteLine(new string('*', starCount) + new string('.', middleDotCount) + new string('*', starCount));
        //hands
        dotCount = 1;
        middleDotCount = (2 * n + 1) - 4;
        while (middleDotCount >= n + 1)
        {
            Console.WriteLine(new string('.', dotCount) + '*' + new string('.', middleDotCount) + '*' + new string('.', dotCount));
            dotCount++;
            middleDotCount -= 2;
        }
        //line - end of hands
        dotCount = n / 2;
        middleDotCount = (n / 2) - 1;
        Console.WriteLine(new string('.', dotCount) + '*' + new string('.', middleDotCount) + '*' + new string('.', middleDotCount) + '*' + new string('.', dotCount));
        //legs
        dotCount = (n / 2) - 1;
        int legDotCount = (n / 2) - 1;
        middleDotCount = 1;
        while (dotCount >= 1)
        {
            Console.WriteLine(new string('.', dotCount) + '*' + new string('.', legDotCount) + '*' + new string('.', middleDotCount) + '*' + new string('.', legDotCount) + '*' + new string('.', dotCount));
            dotCount--;
            middleDotCount += 2;
        }
        //last line
        starCount = (n / 2) + 1;
        middleDotCount = n - 1;
        Console.WriteLine(new string('*', starCount) + new string('.', middleDotCount) + new string('*', starCount));
    }
}