using System;
using System.Numerics;

class TicTacToePower
{
    static void Main()
    {
        //parse cell coordinates
        //important - x are COLUMNS, y are ROWS
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        //parse first cell value
        int value = int.Parse(Console.ReadLine());

        //set up a matrix for the board
        int[,] board = new int[3, 3];
        //index to count the cells
        int index = 0;
        int power = 0;
        //fill the matrix with values
        for (int row = 0; row < board.GetLength(0); row++)
        {
            for (int col = 0; col < board.GetLength(1); col++)
            {
                board[row, col] = value;
                value++;
                index++;
                //store the power to raise the cell
                if (row == y && col == x)
                {
                    power = index;
                }
            }
        }
        //calculate and print the result
        BigInteger result = (BigInteger)Math.Pow(board[y, x], power);
        Console.WriteLine(result);
    }
}