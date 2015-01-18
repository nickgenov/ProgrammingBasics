using System;
using System.Text;

class ExcelColumns
{
    //Telerik Academy Exam 1 @ 28 Dec 2012
    //Problem 3 – Excel Columns
    static void Main()
    {
        //initialise StringBuilder and put all the letters of the index in it
        StringBuilder buildIdentifier = new StringBuilder();
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            buildIdentifier.Append(Console.ReadLine());
        }
        //convert the stored letters to a string
        string identifier = buildIdentifier.ToString();

        //long decimal value for the column index, int is too small
        long index = 0;
        //the power to raise 26 (26 based numbering system)
        int power = 0;

        //go through the string index from right to left
        for (int i = identifier.Length - 1; i >= 0; i--)
        {
            //substract 64 from the ASCII code of the character
            //to get the letter value as a digit in the 26 base number system
            int letter = identifier[i] - 64;
            //add the value of the letter at the current position
            index += letter * (long)Math.Pow(26, power);
            //increase the power by 1
            power++;
        }
        //print the result
        Console.WriteLine(index);
    }
}