using System;

class Anacci
{
    //Telerik Academy Exam 1 @ 28 Dec 2012
    //Problem 2 – A-nacci
    static void Main()
    {
        //parse input parameters
        char first = char.Parse(Console.ReadLine());
        char second = char.Parse(Console.ReadLine());
        int lineCount = int.Parse(Console.ReadLine());

        //counters
        int anacciElement = 1;
        int spaceCount = 1;

        //go through each line
        for (int line = 0; line < lineCount; line++)
        {
            char anacci1 = ReturnAnacci(first, second, anacciElement);
            char anacci2 = ReturnAnacci(first, second, anacciElement + 1);

            if (line == 0)
            {
                Console.WriteLine(anacci1);
                anacciElement++;
            }
            else if (line == 1)
            {
                Console.WriteLine("{0}{1}", anacci1, anacci2);
                anacciElement += 2;
            }
            else
            {
                Console.WriteLine("{0}" + new string(' ', spaceCount) + "{1}", anacci1, anacci2);
                anacciElement += 2;
                spaceCount++;
            }
        }
    }
    //method for returning each anacci member
    public static char ReturnAnacci(char first, char second, int n)
    {
        if (n == 1)
        {
            return first;
        }
        else if (n == 2)
        {
            return second;
        }
        else
        {
            char anacci = ' ';
            for (int i = 3; i <= n; i++)
            {
                int letter = (first - 64) + (second - 64);
                if (letter > 26)
                {
                    letter %= 26;
                }
                //if the first two letters are Z
                if (letter == 0)
                {
                    letter += 65;
                }
                else
                {
                    letter += 64;
                }
                anacci = (char)letter;

                first = second;
                second = anacci;
            }
            return anacci;
        }
    }
}