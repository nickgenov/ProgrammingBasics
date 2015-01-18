using System;

class RockLq
{
    static void Main()
    {
        //parse input
        int n = int.Parse(Console.ReadLine());
        //first line
        Console.WriteLine(new string('.', n) + new string('*', n) + new string('.', n));
        //top
        int startDotCount = n - 2;
        int middleDotCount = n + 2;
        while (startDotCount > 0)
        {
            Console.WriteLine(new string('.', startDotCount) + '*' + new string('.', middleDotCount) + '*' + new string('.', startDotCount));
            startDotCount -= 2;
            middleDotCount += 4;
        }
        //middle row
        Console.WriteLine('*' + new string('.', n - 2) + '*' + new string('.', n) + '*' + new string('.', n - 2) + '*');
        //sleeves
        int sleeveDotCount = n - 4;
        middleDotCount = 1;
        while (sleeveDotCount > 0)
        {
            Console.Write('*' + new string('.', sleeveDotCount) + '*' + new string('.', middleDotCount) + '*' + new string('.', n));
            Console.WriteLine('*' + new string('.', middleDotCount) + '*' + new string('.', sleeveDotCount) + '*');
            sleeveDotCount -= 2;
            middleDotCount += 2;
        }
        //skirt
        startDotCount = n - 1;
        middleDotCount = n;
        while (startDotCount > 0)
        {
            Console.WriteLine(new string('.', startDotCount) + '*' + new string('.', middleDotCount) + '*' + new string('.', startDotCount));
            startDotCount--;
            middleDotCount += 2;
        }
        //end row
        Console.WriteLine(new string('*', 3 * n));
    }
}