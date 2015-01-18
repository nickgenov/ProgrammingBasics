using System;

class PandaScotlandFlag
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        //border case when n = 1
        if (n == 1)
        {
            Console.WriteLine('A');
            return;
        }
        //ASCII char number of the first letter - A
        int letter = 65;
        //print top half
        int sharpCount = n - 2;
        int tildeCount = 0;
        int rowCount = n / 2;
        while (rowCount > 0)
        {
            for (int count = 0; count < tildeCount; count++)
            {
                PrintTilde();
            }
            //print the letter
            PrintLetter(letter);
            //increase the code for the next letter or 
            //go back to 65 (A) if the current letter is Z (code 90)
            letter = ReturnLetterCode(letter);
            for (int count = 0; count < sharpCount; count++)
            {
                PrintSharp();
            }
            PrintLetter(letter);
            letter = ReturnLetterCode(letter);
            for (int count = 0; count < tildeCount; count++)
            {
                PrintTilde();
            }
            tildeCount++;
            sharpCount -= 2;
            rowCount--;
            Console.WriteLine();
        }
        //print middle line
        int dashCount = n / 2;
        for (int count = 0; count < dashCount; count++)
        {
            PrintDash();
        }
        PrintLetter(letter);
        letter = ReturnLetterCode(letter);
        for (int count = 0; count < dashCount; count++)
        {
            PrintDash();
        }
        Console.WriteLine();
        //print bottom half
        tildeCount = (n - 3) / 2;
        sharpCount = 1;
        rowCount = n / 2;
        while (rowCount > 0)
        {
            for (int count = 0; count < tildeCount; count++)
            {
                PrintTilde();
            }
            PrintLetter(letter);
            letter = ReturnLetterCode(letter);
            for (int count = 0; count < sharpCount; count++)
            {
                PrintSharp();
            }
            PrintLetter(letter);
            letter = ReturnLetterCode(letter);
            for (int count = 0; count < tildeCount; count++)
            {
                PrintTilde();
            }
            tildeCount--;
            sharpCount += 2;
            rowCount--;
            Console.WriteLine();
        }
    }
    public static void PrintSharp()
    {
        Console.Write("#");
    }
    public static void PrintTilde()
    {
        Console.Write("~");
    }
    public static void PrintDash()
    {
        Console.Write("-");
    }
    //method for printing the letters
    public static void PrintLetter(int number)
    {
        Console.Write((char)number);
    }
    //method for looping through the alphabet
    public static int ReturnLetterCode(int letter)
    {
        if (letter == 90)
        {
            letter = 65;
        }
        else
        {
            letter++;
        }
        return letter;
    }
}