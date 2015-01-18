using System;

class Eclipse
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        PrintFirstLastRow(num);
        PrintMiddle(num);
        PrintCenterLine(num);
        PrintMiddle(num);
        PrintFirstLastRow(num);
    }
    public static void PrintFirstLastRow(int num)
    {
        int starCount = (2 * num) - 2;
        int middleSpaceCount = num + 1;
        PrintSpace();
        for (int count = 0; count < starCount; count++)
        {
            PrintStar();
        }
        for (int count = 0; count < middleSpaceCount; count++)
        {
            PrintSpace();
        }
        for (int count = 0; count < starCount; count++)
        {
            PrintStar();
        }
        PrintSpace();
        Console.WriteLine();
    }
    public static void PrintMiddle(int num)
    {
        int lineCount = (2 * num) - 2;
        int middleSpaceCount = num - 1;
        int rowCount = (num - 3) / 2;

        while (rowCount > 0)
        {
            PrintStar();
            for (int count = 0; count < lineCount; count++)
            {
                PrintLine();
            }
            PrintStar();
            for (int count = 0; count < middleSpaceCount; count++)
            {
                PrintSpace();
            }
            PrintStar();
            for (int count = 0; count < lineCount; count++)
            {
                PrintLine();
            }
            PrintStar();
            rowCount--;
            Console.WriteLine();
        }
    }
    public static void PrintCenterLine(int num)
    {
        int lineCount = (2 * num) - 2;
        int middleDashCount = num - 1;
        PrintStar();
        for (int count = 0; count < lineCount; count++)
        {
            PrintLine();
        }
        PrintStar();
        for (int count = 0; count < middleDashCount; count++)
        {
            PrintDash();
        }
        PrintStar();
        for (int count = 0; count < lineCount; count++)
        {
            PrintLine();
        }
        PrintStar();
        Console.WriteLine();
    }
    public static void PrintStar()
    {
        Console.Write("*");
    }
    public static void PrintLine()
    {
        Console.Write("/");
    }
    public static void PrintDash()
    {
        Console.Write("-");
    }
    public static void PrintSpace()
    {
        Console.Write(" ");
    }
}