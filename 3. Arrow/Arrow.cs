using System;

class Arrow
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        //first line
        Console.WriteLine(new string('.', n /2) + new string('#', n) + new string('.', n / 2));
        //shaft
        for (int count = 0; count < n - 2; count++)
        {
            Console.WriteLine(new string('.', n / 2) + '#' + new string('.', n - 2) + '#' + new string('.', n / 2));
        }
        //tip start
        Console.WriteLine(new string('#', (n / 2) + 1) + new string('.', n - 2) + new string('#', (n / 2) + 1));
        //tip middle
        int startDotCount = 1;
        int middleDotCount = (2 * n) - 5;
        while (middleDotCount > 0)
        {
            Console.WriteLine(new string('.', startDotCount) + '#' + new string('.', middleDotCount) 
                + '#' + new string('.', startDotCount));
            startDotCount++;
            middleDotCount -= 2;
        }
        //tip
        Console.WriteLine(new string('.', n - 1) + '#' + new string('.', n - 1));
    }
}