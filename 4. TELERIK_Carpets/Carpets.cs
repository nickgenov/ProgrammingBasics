using System;

class Carpets
{
    //Telerik Academy Exam 1 @ 27 Dec 2012
    //Problem 4 – Carpets
    static void Main()
    {
        //parse carpet size
        int n = int.Parse(Console.ReadLine());
        //top half
        int dotCount = (n / 2) - 1;
        int symbolCount = 1;
        int row = 1;
        while (dotCount >= 0)
        {
            Console.Write(new string('.', dotCount));
            PrintLeftSymbolsTop(symbolCount);
            PrintRightSymbolsTop(symbolCount, row);
            Console.WriteLine(new string('.', dotCount));
            dotCount--;
            symbolCount++;
            row++;
        }
        //bottom half
        dotCount = 0;
        symbolCount = n / 2;
        while (dotCount < n / 2)
        {
            Console.Write(new string('.', dotCount));
            PrintLeftSymbolsBottom(symbolCount);
            PrintRightSymbolsBottom(symbolCount, row);
            Console.WriteLine(new string('.', dotCount));
            dotCount++;
            symbolCount--;
            row++;
        }
    }
    public static void PrintLeftSymbolsTop(int symbolCount)
    {
        for (int i = 0; i < symbolCount; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write('/');
            }
            else
            {
                Console.Write(' ');
            }
        }
    
    }
    public static void PrintRightSymbolsTop(int symbolCount, int row)
    {
        if (row % 2 == 0)
        {
            for (int i = 0; i < symbolCount; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(' ');
                }
                else
                {
                    Console.Write('\\');
                }
            }
        }
        else
        {
            for (int i = 0; i < symbolCount; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write('\\');
                }
                else
                {
                    Console.Write(' ');
                }
            }
        }
    }

    public static void PrintLeftSymbolsBottom(int symbolCount)
    {
        for (int i = 0; i < symbolCount; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write('\\');
            }
            else
            {
                Console.Write(' ');
            }
        }

    }
    public static void PrintRightSymbolsBottom(int symbolCount, int row)
    {
        if (row % 2 == 0)
        {
            for (int i = 0; i < symbolCount; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write('/');
                }
                else
                {
                    Console.Write(' ');
                }
            }
        }
        else
        {
            for (int i = 0; i < symbolCount; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(' ');
                }
                else
                {
                    Console.Write('/');
                }
            }
        }
    }
}