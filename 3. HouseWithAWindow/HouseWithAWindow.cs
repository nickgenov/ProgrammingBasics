using System;

class HouseWithAWindow
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        //print top
        Console.WriteLine(new string('.', n - 1) + '*' + new string('.', n - 1));
        //print roof
        int startDotCount = n - 2;
        int middleDotCount = 1;
        while (startDotCount >= 0)
        {
            Console.WriteLine(new string('.', startDotCount) + '*' + 
                new string('.', middleDotCount) + '*' + new string('.', startDotCount));
            startDotCount--;
            middleDotCount += 2;
        }
        Console.WriteLine(new string('*', 2 * n - 1));
        //print wall
        int rowsNoWindow = n / 4;
        middleDotCount = (2 * n) - 3;
        for (int count = 0; count < rowsNoWindow; count++)
        {
            Console.WriteLine('*' + new string('.', middleDotCount) + '*');
        }
        //print window
        int wallDotCount = n / 2;
        int windowStarCount = n - 3;
        int windowRowCount = n / 2;
        for (int count = 0; count < windowRowCount; count++)
        {
            Console.WriteLine('*' + new string('.', wallDotCount) +
                new string('*', windowStarCount) + new string('.', wallDotCount) + '*');
        }
        //print wall
        for (int count = 0; count < rowsNoWindow; count++)
        {
            Console.WriteLine('*' + new string('.', middleDotCount) + '*');
        }
        //print floor
        Console.WriteLine(new string('*', 2 * n - 1));
    }
}