using System;

class ProgrammerDNA
{
    static void Main()
    {
        int length = int.Parse(Console.ReadLine());
        char letter = char.Parse(Console.ReadLine());

        while (length >= 0)
        {
            int dotCount = 3;
            int letterCount = 1;
            while (dotCount >= 0)
            {
                for (int count = 0; count < dotCount; count++)
                {
                    PrintDot();
                }
                for (int count = 0; count < letterCount; count++)
                {
                    //key part of the solution
                    Console.Write(letter);
                    //add 1 to the ASCII code of the letter
                    letter++;
                    //if the letter reaches H, reset it to A
                    if (letter > 71)
                    {
                        letter = (char)65;
                    }
                }
                for (int count = 0; count < dotCount; count++)
                {
                    PrintDot();
                }
                dotCount--;
                letterCount += 2;
                Console.WriteLine();
                length--;
                if (length == 0)
                {
                    return;
                }
            }
            dotCount = 1;
            letterCount = 5;
            while (dotCount < 4)
            {
                for (int count = 0; count < dotCount; count++)
                {
                    PrintDot();
                }
                for (int count = 0; count < letterCount; count++)
                {
                    Console.Write(letter);
                    letter++;
                    if (letter > 71)
                    {
                        letter = (char)65;
                    }
                }
                for (int count = 0; count < dotCount; count++)
                {
                    PrintDot();
                }
                dotCount++;
                letterCount -= 2;
                Console.WriteLine();
                length--;
                if (length == 0)
                {
                    return;
                }
            }
        }
    }
    public static void PrintDot()
    {
        Console.Write(".");
    }
}