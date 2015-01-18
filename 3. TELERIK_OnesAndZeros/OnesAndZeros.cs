using System;

class OnesAndZeros
{
    //Telerik Academy Exam 1 @ 5 December 2013 Evening
    //Problem 3 – Ones and Zeros
    static void Main()
    {
        //parse the number to print
        int n = int.Parse(Console.ReadLine());

        //store its binary digits in an array
        int[] binary = DecimalToBinary(n);

        //print one row at a time
        for (int row = 1; row <= 5 ; row++)
        {
            //print only the last 16 bits, as required
            for (int i = 16; i <= 31; i++)
            {
                //get the bit value
                int bit = binary[i];
                //string for the symbols to print
                string symbols = string.Empty;

                //use the methods for each row to be printed
                if (bit == 1 && i < 31)
                {
                    //if it is not the last row, add a dot at the end
                    symbols = ReturnOnePrintString(row) + '.';
                }
                else if (bit == 1 && i == 31)
                {
                    symbols = ReturnOnePrintString(row);
                }
                else if (bit == 0 && i < 31)
                {
                    //if it is not the last row, add a dot at the end
                    symbols = ReturnZeroPrintString(row) + '.';
                }
                else if (bit == 0 && i == 31)
                {
                    symbols = ReturnZeroPrintString(row);
                }
                //write the symbols on the console
                Console.Write(symbols);
            }
            //start a new row
            Console.WriteLine();
        }
    }
    //store binary digits in an array
    public static int[] DecimalToBinary(int number)
    {
        int[] binary = new int[32];

        int index = 31;
        while (number > 0)
        {
            int bit = number & 1;
            number >>= 1;
            binary[index] = bit;
            index--;
        }
        return binary;
    }
    public static string ReturnOnePrintString(int row)
    {
        string symbols = string.Empty;
        switch (row)
        {
            case 1: 
            case 3:
            case 4: symbols = "" + '.' + '#' + '.';
                break;
            case 2: symbols = new string('#', 2) + '.';
                break;
            case 5: symbols = new string('#', 3);
                break;
        }
        return symbols;
    }
    public static string ReturnZeroPrintString(int row)
    {
        string symbols = string.Empty;
        switch (row)
        {
            case 2:
            case 3:
            case 4: symbols = "" + '#' + '.' + '#';
                break;
            case 1: 
            case 5: symbols = new string('#', 3);
                break;
        }
        return symbols;
    }
}