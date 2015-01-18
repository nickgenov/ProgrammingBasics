using System;

class Sunglasses
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        PrintFirstLastLine(n);
        PrintMiddleLines(n);
        PrintCenterLine(n);
        PrintMiddleLines(n);
        PrintFirstLastLine(n);
    }
    public static void PrintFirstLastLine(int num)
    {
        int starCount = 2 * num;
        int spaceCount = num;
        for (int count = 0; count < starCount; count++)
        {
            PrintStar();
        }
        for (int count = 0; count < spaceCount; count++)
        {
            PrintSpace();
        }
        for (int count = 0; count < starCount; count++)
        {
            PrintStar();
        }
        Console.WriteLine();
    }
    public static void PrintMiddleLines(int num)
    {
        int rowCount = (num - 3) / 2;
        int lineCount = (2 * num) - 2;
        int spaceCount = num;

        while (rowCount > 0)
        {
            PrintStar();
            for (int count = 0; count < lineCount; count++)
            {
                PrintTiltedLine();
            }
            PrintStar();
            for (int count = 0; count < spaceCount; count++)
            {
                PrintSpace();
            }
            PrintStar();
            for (int count = 0; count < lineCount; count++)
            {
                PrintTiltedLine();
            }
            PrintStar();
            rowCount--;
            Console.WriteLine();
        }
    }
    public static void PrintCenterLine(int num)
    {
        int lineCount = (2 * num) - 2;
        int pipeCount = num;

        PrintStar();
        for (int count = 0; count < lineCount; count++)
        {
            PrintTiltedLine();
        }
        PrintStar();
        for (int count = 0; count < pipeCount; count++)
        {
            PrintPipe();
        }
        PrintStar();
        for (int count = 0; count < lineCount; count++)
        {
            PrintTiltedLine();
        }
        PrintStar();
        Console.WriteLine();
    }
    public static void PrintStar()
    {
        Console.Write("*");
    }
    public static void PrintSpace()
    {
        Console.Write(" ");
    }
    public static void PrintTiltedLine()
    {
        Console.Write("/");
    }
    public static void PrintPipe()
    {
        Console.Write("|");
    }
}