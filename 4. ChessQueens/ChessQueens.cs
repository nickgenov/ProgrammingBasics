using System;

class ChessQueens
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        string[,] array = new string[n, n];
        bool validSolution = false;

        char rowName = 'a';
        int colName = 1;

        for (int row = 0; row < array.GetLength(0); row++)
        {
            colName = 1;
            for (int col = 0; col < array.GetLength(1); col++)
            {
                array[row, col] = "" + rowName + colName;
                colName++;
            }
            rowName++;
        }
        for (int row = 0; row < array.GetLength(0); row++)
        {
            for (int col = 0; col < array.GetLength(1); col++)
            {
                //row positions check
                if (col - (d + 1) >= 0)
                {
                    Console.WriteLine("{0} - {1}", array[row, col], array[row, col - (d + 1)]);
                    validSolution = true;
                }
                if (col + (d + 1) <= n - 1)
                {
                    Console.WriteLine("{0} - {1}", array[row, col], array[row, col + (d + 1)]);
                    validSolution = true;
                }
                //column positions check
                if (row - (d + 1) >= 0)
                {
                    Console.WriteLine("{0} - {1}", array[row, col], array[row - (d + 1), col]);
                    validSolution = true;
                }
                if (row + (d + 1) <= n - 1)
                {
                    Console.WriteLine("{0} - {1}", array[row, col], array[row + (d + 1), col]);
                    validSolution = true;
                }
                //diagonal positions check
                if (col - (d + 1) >= 0 && row - (d + 1) >= 0)
                {
                    Console.WriteLine("{0} - {1}", array[row, col], array[row - (d + 1), col - (d + 1)]);
                    validSolution = true;
                }
                if (col - (d + 1) >= 0 && row + (d + 1) <= n - 1)
                {
                    Console.WriteLine("{0} - {1}", array[row, col], array[row + (d + 1), col - (d + 1)]);
                    validSolution = true;
                }
                if (col + (d + 1) <= n - 1 && row - (d + 1) >= 0)
                {
                    Console.WriteLine("{0} - {1}", array[row, col], array[row - (d + 1), col + (d + 1)]);
                    validSolution = true;
                }
                if (col + (d + 1) <= n - 1 && row + (d + 1) <= n - 1)
                {
                    Console.WriteLine("{0} - {1}", array[row, col], array[row + (d + 1), col + (d + 1)]);
                    validSolution = true;
                }
            }
        }
        if (validSolution == false)
        {
            Console.WriteLine("No valid positions");
        }
    }
}