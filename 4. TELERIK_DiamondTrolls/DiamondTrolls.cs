using System;

class DiamondTrolls
{
    static void Main()
    {
        //parse input
        int n = int.Parse(Console.ReadLine());

        //total rows of the diamond
        int rows = 6 + (((n - 3) / 2) * 3);
        //counter for the printed rows
        int rowCount = 0;

        while (rowCount < rows)
        {
            //first line
            int dotCount = (n + 1) / 2;
            Console.WriteLine(new string('.', dotCount) + new string('*', n) + new string('.', dotCount));
            dotCount--;
            rowCount++;
            //top half
            int middleDotCount = n - dotCount - 1;
            while (dotCount >= 1)
            {
                Console.WriteLine(new string('.', dotCount) + '*' + new string('.', middleDotCount) + '*' + new string('.', middleDotCount) + '*' + new string('.', dotCount));
                dotCount--;
                middleDotCount++;
                rowCount++;
            }
            //center line
            Console.WriteLine(new string('*', (2 * n) + 1));
            rowCount++;
            //bottom half
            dotCount = 1;
            middleDotCount = n - 2;
            while (middleDotCount >= 0)
            {
                Console.WriteLine(new string('.', dotCount) + '*' + new string('.', middleDotCount) + '*' + new string('.', middleDotCount) + '*' + new string('.', dotCount));
                dotCount++;
                middleDotCount--;
                rowCount++;
            }
            //last line
            Console.WriteLine(new string('.', dotCount) + '*' + new string('.', dotCount));
            rowCount++;
        }
    }
}