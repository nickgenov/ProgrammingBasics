using System;

class Boat
{
    static void Main()
    {
        //parse input
        int n = int.Parse(Console.ReadLine());

        //sail top
        int leftDotCount = n - 1;
        int rightDotCount = n;
        int starCount = 1;
        while (leftDotCount >= 0)
        {
            Console.WriteLine(new string('.', leftDotCount) + new string('*', starCount) + new string('.', rightDotCount));
            leftDotCount -= 2;
            starCount += 2;
        }
        
        //sail bottom
        starCount = n - 2;
        leftDotCount = 2;
        while (starCount >= 1)
        {
            Console.WriteLine(new string('.', leftDotCount) + new string('*', starCount) + new string('.', rightDotCount));
            leftDotCount += 2;
            starCount -= 2;
        }

        //boat hull
        starCount = 2 * n;
        leftDotCount = 0;
        int rows = (n - 1) / 2;
        while (rows > 0)
        {
            Console.WriteLine(new string('.', leftDotCount) + new string('*', starCount) + new string('.', leftDotCount));
            starCount -= 2;
            leftDotCount++;
            rows--;
        }
    }
}