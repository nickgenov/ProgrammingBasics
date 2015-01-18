using System;

class Tetris
{
    //C# Basics December 2014 Lab
    static void Main()
    {
        //parse input data
        string inputFieldSize = Console.ReadLine();
        string[] fieldSize = SplitString(inputFieldSize);
        int rows = int.Parse(fieldSize[0]);
        int columns = int.Parse(fieldSize[1]);

        string[] input = new string[rows];
        for (int i = 0; i < input.Length; i++)
        {
            input[i] = Console.ReadLine();
        }
        
        //store the data in a two-dimensional array
        string[,] field = new string[rows, columns];
        for (int row = 0; row < field.GetLength(0); row++)
        {
            string rowData = input[row];
            for (int col = 0; col < field.GetLength(1); col++)
            {
                field[row, col] = Convert.ToString(rowData[col]);
            }
        }
        //check for "I" figures
        int figuresCountI = 0;
        for (int col = 0; col < field.GetLength(1); col++)
        {
            for (int row = 0; row < field.GetLength(0) - 3; row++)
            {
                bool foundFigure = (field[row, col] == "o"
                    && field[row, col] == field[row + 1, col]
                    && field[row + 1, col] == field[row + 2, col]
                    && field[row + 2, col] == field[row + 3, col]);
                if (foundFigure)
                {
                    figuresCountI++;
                }
            }
        }
        //check for "L" figures
        int figuresCountL = 0;
        for (int col = 0; col < field.GetLength(1) - 1; col++)
        {
            for (int row = 0; row < field.GetLength(0) - 2; row++)
            {
                bool foundFigure = (field[row, col] == "o"
                    && field[row, col] == field[row + 1, col]
                    && field[row + 1, col] == field[row + 2, col]
                    && field[row + 2, col] == field[row + 2, col + 1]);
                if (foundFigure)
                {
                    figuresCountL++;
                }
            }
        }
        //check for "J" figures
        int figuresCountJ = 0;
        for (int col = 1; col < field.GetLength(1); col++)
        {
            for (int row = 0; row < field.GetLength(0) - 2; row++)
            {
                bool foundFigure = (field[row, col] == "o"
                    && field[row, col] == field[row + 1, col]
                    && field[row + 1, col] == field[row + 2, col]
                    && field[row + 2, col] == field[row + 2, col - 1]);
                if (foundFigure)
                {
                    figuresCountJ++;
                }
            }
        }
        //check for "O" figures
        int figuresCountO = 0;
        for (int col = 0; col < field.GetLength(1) - 1; col++)
        {
            for (int row = 0; row < field.GetLength(0) - 1; row++)
            {
                bool foundFigure = (field[row, col] == "o"
                    && field[row, col] == field[row, col + 1]
                    && field[row, col + 1] == field[row + 1, col]
                    && field[row + 1, col] == field[row + 1, col + 1]);
                if (foundFigure)
                {
                    figuresCountO++;
                }
            }
        }
        //check for "Z" figures
        int figuresCountZ = 0;
        for (int col = 0; col < field.GetLength(1) - 2; col++)
        {
            for (int row = 0; row < field.GetLength(0) - 1; row++)
            {
                bool foundFigure = (field[row, col] == "o"
                    && field[row, col] == field[row, col + 1]
                    && field[row, col + 1] == field[row + 1, col + 1]
                    && field[row + 1, col + 1] == field[row + 1, col + 2]);
                if (foundFigure)
                {
                    figuresCountZ++;
                }
            }
        }
        //check for "S" figures
        int figuresCountS = 0;
        for (int col = 1; col < field.GetLength(1) - 1; col++)
        {
            for (int row = 0; row < field.GetLength(0) - 1; row++)
            {
                bool foundFigure = (field[row, col] == "o"
                    && field[row, col] == field[row, col + 1]
                    && field[row, col + 1] == field[row + 1, col - 1]
                    && field[row + 1, col - 1] == field[row + 1, col]);
                if (foundFigure)
                {
                    figuresCountS++;
                }
            }
        }
        //check for "T" figures
        int figuresCountT = 0;
        for (int col = 0; col < field.GetLength(1) - 2; col++)
        {
            for (int row = 0; row < field.GetLength(0) - 1; row++)
            {
                bool foundFigure = (field[row, col] == "o"
                    && field[row, col] == field[row, col + 1]
                    && field[row, col + 1] == field[row, col + 2]
                    && field[row, col + 2] == field[row + 1, col + 1]);
                if (foundFigure)
                {
                    figuresCountT++;
                }
            }
        }
        //print the result
        Console.Write("I:{0}, ", figuresCountI);
        Console.Write("L:{0}, ", figuresCountL);
        Console.Write("J:{0}, ", figuresCountJ);
        Console.Write("O:{0}, ", figuresCountO);
        Console.Write("Z:{0}, ", figuresCountZ);
        Console.Write("S:{0}, ", figuresCountS);
        Console.WriteLine("T:{0}", figuresCountT);
    }
    public static string[] SplitString(string input)
    {
        string[] split = input.Split(' ');
        return split;
    }
}