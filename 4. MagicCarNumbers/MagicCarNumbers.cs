using System;

class MagicCarNumbers
{
    static void Main()
    {
        //initialise an array for calculating the weight of the last 2 letters
        char[] letters = { 'A', 'B', 'C', 'E', 'H', 'K', 'M', 'P', 'T', 'X' };
        //enter magic weight
        int magicWeight = int.Parse(Console.ReadLine());
        //counter for the number of cars with a magic number
        int carsCount = 0;

        for (int a = 0; a <= 9; a++)
        {
            for (int b = 0; b <= 9; b++)
            {
                for (int c = 0; c <= 9; c++)
                {
                    for (int d = 0; d <= 9; d++)
                    {
                        for (int i = 0; i <= 9; i++)
                        {
                            for (int j = 0; j <= 9; j++)
                            {
                                int letterWeight1 = CalculateLetterWeight(letters[i]);
                                int letterWeight2 = CalculateLetterWeight(letters[j]);
                                int numberWeight = 40 + a + b + c + d + letterWeight1 + letterWeight2;

                                bool hasMagicWeight = magicWeight == numberWeight;
                                bool formatIsValid = CheckNumberFormat(a, b, c, d);

                                if (hasMagicWeight && formatIsValid)
                                {
                                    carsCount++;
                                    //Console.Write("CA{0}{1}{2}{3}{4}{5} ", a, b, c, d, letters[i], letters[j]);
                                }
                            }
                        }
                    }
                }
            }
        }
        Console.WriteLine(carsCount);
    }
    public static int CalculateLetterWeight(char letter)
    {
        int letterWeight = 0;
        switch (letter)
        {
            case 'A': letterWeight = 10;
                break;
            case 'B': letterWeight = 20;
                break;
            case 'C': letterWeight = 30;
                break;
            case 'E': letterWeight = 50;
                break;
            case 'H': letterWeight = 80;
                break;
            case 'K': letterWeight = 110;
                break;
            case 'M': letterWeight = 130;
                break;
            case 'P': letterWeight = 160;
                break;
            case 'T': letterWeight = 200;
                break;
            case 'X': letterWeight = 240;
                break;
            default: letterWeight = 0;
                break;
        }
        return letterWeight;
    }
    public static bool CheckNumberFormat(int a, int b, int c, int d)
    {
        bool formatIsValid = false;
        if (a == b && a == c && a == d)
        {
            formatIsValid = true;
        }
        if (a != b && b == c && b == d)
        {
            formatIsValid = true;
        }
        if (a == b && a == c && a != d)
        {
            formatIsValid = true;
        }
        if (a == b && b != c && c == d)
        {
            formatIsValid = true;
        }
        if (a == c && b != c && b == d)
        {
            formatIsValid = true;
        }
        if (a == d && a != b && b == c)
        {
            formatIsValid = true;
        }
        return formatIsValid;
    }
}

