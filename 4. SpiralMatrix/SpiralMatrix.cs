using System;

class SpiralMatrix
{
    static void Main()
    {
        //parse input
        int n = int.Parse(Console.ReadLine());
        string keyword = Console.ReadLine();

        //fill the matrix with the letters of the keyword
        char[,] matrix = new char[n, n];
        int row = 0;
        int col = 0;
        string direction = "right";
        int maxRotations = n * n;

        //starting letter position in the word, for cell [0, 0]
        int pos = 0;

        //fill the matrix with the letters of the keyword
        for (int i = 1; i <= maxRotations; i++)
        {
            if (direction == "right" && (col > n - 1 || matrix[row, col] != 0))
            {
                direction = "down";
                col--;
                row++;
            }
            if (direction == "down" && (row > n - 1 || matrix[row, col] != 0))
            {
                direction = "left";
                row--;
                col--;
            }
            if (direction == "left" && (col < 0 || matrix[row, col] != 0))
            {
                direction = "up";
                col++;
                row--;
            }
            if (direction == "up" && row < 0 || matrix[row, col] != 0)
            {
                direction = "right";
                row++;
                col++;
            }

            //start from the first letter in the word after the last is in the array
            if (pos > keyword.Length - 1)
            {
                pos = 0;
            }
            //put the letter in the array
            matrix[row, col] = keyword[pos];
            pos++;

            if (direction == "right")
            {
                col++;
            }
            if (direction == "down")
            {
                row++;
            }
            if (direction == "left")
            {
                col--;
            }
            if (direction == "up")
            {
                row--;
            }
        }

        //display the matrix to check
        //for (int r = 0; r < n; r++)
        //{
        //    for (int c = 0; c < n; c++)
        //    {
        //        Console.Write("{0} ", matrix[r, c]);
        //    }
        //    Console.WriteLine();
        //}

        //check the sum of letters on each row
        int maxRowIndex = 0;
        int maxRowSum = int.MinValue;

        for (int rowResult = 0; rowResult < matrix.GetLength(0); rowResult++)
        {
            int rowSum = 0;
            for (int colResult = 0; colResult < matrix.GetLength(1); colResult++)
            {
                rowSum += ReturnLetterWeight(matrix[rowResult, colResult]);
            }
            if (rowSum > maxRowSum)
            {
                maxRowSum = rowSum;
                maxRowIndex = rowResult;
            }
        }

        //display the result on the console!!! 500/500 !!!
        Console.WriteLine("{0} - {1}", maxRowIndex, maxRowSum);

    }
    public static int ReturnLetterWeight(char letter)
    {
        int weight = 0;
        if (letter >= 65 && letter <= 90)
        {
            weight = (letter - 64) * 10;
        }
        else if (letter >= 97 && letter <= 122)
        {
            weight = (letter - 96) * 10;
        }
        return weight;
    }
}