using System;

class FunWithMatrices
{
    //C# Basics December 2014 Lab
    static void Main()
    {
        //parse the matrix parameters
        double start = double.Parse(Console.ReadLine());
        double step = double.Parse(Console.ReadLine());

        //fill the matrix with numbers
        double[,] matrix = new double[4, 4];
        double value = 0;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (row == 0 && col == 0)
                {
                    matrix[row, col] = start;
                }
                else
                {
                    matrix[row, col] = value + step;
                }
                value = matrix[row, col];
            }
        }

        //start the game
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "Game Over!")
            {
                //leave the infinite loop when the game ends
                break;
            }
            else
            {
                //split the command to different variables we can use
                string[] command = SplitString(input);
                int row = int.Parse(command[0]);
                int col = int.Parse(command[1]);
                string operation = command[2];
                double num = double.Parse(command[3]);

                if (operation == "multiply")
                {
                    matrix[row, col] *= num; 
                }
                else if (operation == "sum")
                {
                    matrix[row, col] += num; 
                }
                else if (operation == "power")
                {
                    matrix[row, col] = Math.Pow(matrix[row, col], num);
                }
            }
        }
        //calculate the diagonal sums
        double leftDiagonalSum = matrix[0, 0] + matrix[1, 1] + matrix[2, 2] + matrix[3, 3];
        double rightDiagonalSum = matrix[3, 0] + matrix[2, 1] + matrix[1, 2] + matrix[0, 3];

        //calculate the max row an max column
        int maxRowIndex = 0;
        int maxColIndex = 0;
        double maxRowSum = double.MinValue;
        double maxColSum = double.MinValue;

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            double rowSum = 0;
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                rowSum += matrix[row, col];
            }
            if (rowSum > maxRowSum)
            {
                maxRowSum = rowSum;
                maxRowIndex = row;
            }
        }
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            double colSum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                colSum += matrix[row, col];
            }
            if (colSum > maxColSum)
            {
                maxColSum = colSum;
                maxColIndex = col;
            }
        }

        //print the result
        if (maxRowSum >= maxColSum && maxRowSum >= leftDiagonalSum && maxRowSum >= rightDiagonalSum )
        {
            Console.WriteLine("ROW[{0}] = {1:F2}", maxRowIndex, maxRowSum);
        }
        else if (maxColSum >= leftDiagonalSum && maxColSum >= rightDiagonalSum)
        {
            Console.WriteLine("COLUMN[{0}] = {1:F2}", maxColIndex, maxColSum);
        }
        else if (leftDiagonalSum >= rightDiagonalSum)
        {
            Console.WriteLine("LEFT-DIAGONAL = {0:F2}", leftDiagonalSum);
        }
        else
        {
            Console.WriteLine("RIGHT-DIAGONAL = {0:F2}", rightDiagonalSum);
        }
    }
    public static string[] SplitString(string input)
    {
        string[] split = input.Split(' ');
        return split;
    }
}