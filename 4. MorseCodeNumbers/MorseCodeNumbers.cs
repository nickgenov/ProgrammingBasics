using System;

class MorseCodeNumbers
{
    static void Main()
    {
        //parse the input number
        int num = int.Parse(Console.ReadLine());
        //calculate the sum of digits
        int nSum = SumOfDigits(num);
        //variable for the found solutions
        bool validSolution = false;
        //loop through all combinations of the 6 numbers
        for (int a = 0; a <= 5; a++)
        {
            for (int b = 0; b <= 5; b++)
            {
                for (int c = 0; c <= 5; c++)
                {
                    for (int d = 0; d <= 5; d++)
                    {
                        for (int e = 0; e <= 5; e++)
                        {
                            for (int f = 0; f <= 5; f++)
                            {
                                //calculate the morse product
                                int morseProduct = a * b * c * d * e * f;
                                if (morseProduct == nSum)
                                {
                                    //found a solution
                                    validSolution = true;
                                    //get morse code strings for each number
                                    string morseA = ReturnMorseCode(a);
                                    string morseB = ReturnMorseCode(b);
                                    string morseC = ReturnMorseCode(c);
                                    string morseD = ReturnMorseCode(d);
                                    string morseE = ReturnMorseCode(e);
                                    string morseF = ReturnMorseCode(f);
                                    //write the result to the console
                                    Console.WriteLine("{0}|{1}|{2}|{3}|{4}|{5}|",
                                        morseA, morseB, morseC, morseD, morseE, morseF);
                                }
                            }
                        }
                    }
                }
            }
        }
        //if no solution is found, print No
        if (validSolution == false)
        {
            Console.WriteLine("No");
        }
    }
    public static int SumOfDigits(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }
    public static string ReturnMorseCode(int number)
    {
        string morseCode = string.Empty;
        switch (number)
        {
            case 0: morseCode = "-----";
                break;
            case 1: morseCode = ".----";
                break;
            case 2: morseCode = "..---";
                break;
            case 3: morseCode = "...--";
                break;
            case 4: morseCode = "....-";
                break;
            case 5: morseCode = ".....";
                break;
        }
        return morseCode;
    }
}

