using System;

class House
{
    static void Main()
    {
        //parse input
        int n = int.Parse(Console.ReadLine());
        int rowCount = n - 1;
        //print roof top
        Console.WriteLine(new string('.', n / 2) + '*' + new string('.', n / 2));
        rowCount--;
        //print roof sides
        int dotCount = (n / 2) - 1;
        int middleDotCount = 1;
        while (dotCount > 0)
        {
            Console.WriteLine(new string('.', dotCount) + '*' + new string('.', middleDotCount) + '*' + new string('.', dotCount));
            dotCount--;
            middleDotCount +=2;
            rowCount--;
        }
        //print roof bottom
        Console.WriteLine(new string('*', n));
        rowCount--;
        //print walls
        while (rowCount > 0)
        {
            Console.WriteLine(new string('.', n / 4) + '*' + new string('.', (n - 2 * (n / 4) - 2)) + '*' + new string('.', n / 4));
            rowCount--;
        }
        //print base
        Console.WriteLine(new string('.', n / 4) + new string('*', n - 2 * (n / 4)) + new string('.', n / 4));
    }
}
