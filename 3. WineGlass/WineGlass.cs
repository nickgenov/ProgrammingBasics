using System;

class WineGlass
{
    static void Main()
    {
        //parse input
        int n = int.Parse(Console.ReadLine());
        int totalRowCount = 0;
        //print cup
        int dotCount = 0;
        int starCount = n - 2;
        while (starCount >= 0)
        {
            Console.WriteLine(new string('.', dotCount) + new string('\\', 1) + new string('*', starCount) + new string('/', 1) + new string('.', dotCount));
            dotCount++;
            starCount -= 2;
            totalRowCount++;
        }
        //print stem
        if (n >= 12)
        {
            int rowCount = (n / 2) - 2;
            dotCount = (n / 2) - 1;
            while (rowCount > 0)
            {
                Console.WriteLine(new string('.', dotCount) + new string('|', 2) + new string('.', dotCount));
                rowCount--;
                totalRowCount++;
            }
        }
        else if (n < 12)
        {
            int rowCount = (n / 2) - 1;
            dotCount = (n / 2) - 1;
            while (rowCount > 0)
            {
                Console.WriteLine(new string('.', dotCount) + new string('|', 2) + new string('.', dotCount));
                rowCount--;
                totalRowCount++;
            }
        }
        //last lines
        while (totalRowCount < n)
        {
            Console.WriteLine(new string('-', n));
            totalRowCount++;
        }
    }
}
