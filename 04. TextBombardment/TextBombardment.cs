using System;
using System.Text;

class TextBombardment
{
    static void Main()
    {
        //parse input
        string text = Console.ReadLine();
        int lineWidth = int.Parse(Console.ReadLine());
        string columnsToBomb = Console.ReadLine();

        //calculate the number of rows needed to fit the text
        decimal textLength = text.Length;
        int rows = (int)Math.Ceiling(textLength / lineWidth);

        //initialise an array of characters
        char[,] table = new char[rows, lineWidth];

        //fill it with the letters of the text
        int index = 0;
        for (int row = 0; row < table.GetLength(0); row++)
        {
            for (int col = 0; col < table.GetLength(1); col++)
            {
                table[row, col] = text[index];
                index++;
                if (index > (textLength - 1))
                {
                    break;
                }
            }
        }
        ////check the letters in the table
        //for (int row = 0; row < table.GetLength(0); row++)
        //{
        //    for (int col = 0; col < table.GetLength(1); col++)
        //    {
        //        Console.Write("{0} ", table[row, col]);
        //    }
        //    Console.WriteLine();
        //}

        //split the command to bomb columns to an array
        int[] bomb = SplitString(columnsToBomb);

        //go through the array column by column
        for (int col = 0; col < table.GetLength(1); col++)
        {
            for (int i = 0; i < bomb.Length; i++)
            {
                if (bomb[i] == col)
                {
                    //check if the bomb has met a character (not space) and has exploded
                    bool bombExploded = false;

                    //go through each column from top to bottom
                    for (int row = 0; row < table.GetLength(0); row++)
                    {
                        //the ASCII code for SPACE is 32
                        if (table[row, col] != 32)
                        {
                            bombExploded = true;
                        }
                        //if the bomb has exploded and the next cell
                        //is a space, leave the inner loop
                        //we MUST NOT bomb the letters below
                        if (bombExploded == true && table[row, col] == 32)
                        {
                            break;
                        }

                        //set the cell to a SPACE ASCII symbol
                        table[row, col] = (char)32;
                    }
                }
            }
        }
        //assemble the final result
        StringBuilder build = new StringBuilder();
        for (int row = 0; row < table.GetLength(0); row++)
        {
            for (int col = 0; col < table.GetLength(1); col++)
            {
                //DO NOT add NULL string values at the end!
                if (table[row, col] != '\0')
                {
                    build.Append(table[row, col]);
                }
            }
        }
        string result = build.ToString();

        //print the final result!!!
        Console.WriteLine(result);
    }
    public static int[] SplitString(string input)
    {
        string[] array = input.Split(' ');
        int[] numbers = new int[array.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(array[i]);
        }
        return numbers;
    }
}