using System;

class Plane
{
    static void Main()
    {
        //parse input
        int n = int.Parse(Console.ReadLine());
        //first row
        Console.WriteLine(new string('.', (3 * n) / 2) + '*' + new string('.', (3 * n) / 2));
        //plane head
        int dotCount = ((3 * n) / 2) - 1;
        int middleDotCount = 1;
        while (dotCount >= n - 2)
        {
            Console.WriteLine(new string('.', dotCount) + '*' + new string('.', middleDotCount) + '*' + new string('.', dotCount));
            dotCount--;
            middleDotCount += 2;
        }
        //wings start
        dotCount = n - 4;
        middleDotCount = (3 * n) - (n - 4) * 2 - 2;
        while (dotCount >= 1)
        {
            Console.WriteLine(new string('.', dotCount) + '*' + new string('.', middleDotCount) + '*' + new string('.', dotCount));
            dotCount -= 2;
            middleDotCount += 4;
        }
        //line
        Console.WriteLine('*' + new string('.', n - 2) + '*' + new string('.', n) + '*' + new string('.', n - 2) + '*');
        //wings
        dotCount = n - 4;
        middleDotCount = 1;
        while (dotCount >= 1)
        {
            Console.WriteLine('*' + new string('.', dotCount) + '*' + new string('.', middleDotCount) + '*' + new string('.', n) + '*' + new string('.', middleDotCount) + '*' + new string('.', dotCount) + '*');
            dotCount -= 2;
            middleDotCount += 2;
        }
        //tail
        dotCount = n - 1;
        middleDotCount = n;
        while (dotCount >= 1)
        {
            Console.WriteLine(new string('.', dotCount) + '*' + new string('.', middleDotCount) + '*' + new string('.', dotCount));
            dotCount--;
            middleDotCount += 2;
        }
        //end line
        Console.WriteLine(new string('*', 3 * n));
    }
}