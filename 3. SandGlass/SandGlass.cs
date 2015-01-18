using System;

class SandGlass
{
    static void Main()
    {
        //parse input
        int n = int.Parse(Console.ReadLine());
        //top half
        int dotCount = 0;
        int starCount = n;
        while (starCount >= 1)
        {
            Console.WriteLine(new string('.', dotCount) + new string('*', starCount) + new string('.', dotCount));
            dotCount++;
            starCount -= 2;
        }
        //bottom half
        dotCount = (n - 1) / 2 - 1;
        starCount = 3;
        while (dotCount >= 0)
        {
            Console.WriteLine(new string('.', dotCount) + new string('*', starCount) + new string('.', dotCount));
            dotCount--;
            starCount += 2;
        }
    }
}