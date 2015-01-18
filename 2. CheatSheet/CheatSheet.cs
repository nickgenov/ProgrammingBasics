using System;

class CheatSheet
{
    static void Main()
    {
        //parse input
        int rowCount = int.Parse(Console.ReadLine());
        int colCount = int.Parse(Console.ReadLine());

        long startVertical = long.Parse(Console.ReadLine());
        long startHorizontal = long.Parse(Console.ReadLine());

        //initialise array
        long[,] sheet = new long[rowCount, colCount];
        //value for cell[0,0]
        long startNum = startVertical * startHorizontal;
        long cellValue = startNum;

        //put the values in the array
        for (int row = 0; row < sheet.GetLength(0); row++)
        {
            for (int col = 0; col < sheet.GetLength(1); col++)
            {
                sheet[row, col] = cellValue;
                cellValue += (startVertical + row);
            }
            cellValue = startNum + (startHorizontal * (row + 1));
        }

        //print the array on the console
        for (int row = 0; row < sheet.GetLength(0); row++)
        {
            for (int col = 0; col < sheet.GetLength(1); col++)
            {
                if (col == (sheet.GetLength(1) - 1))
                {
                    Console.WriteLine(sheet[row, col]);
                }
                else
                {
                    Console.Write("{0} ", sheet[row, col]);
                }
            }
        }
    }
}