using System;

class NineDigitMagicNumbers
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());

        bool validSolution = false;

        for (int a = 1; a <= 7; a++)
        {
            for (int b = 1; b <= 7; b++)
            {
                for (int c = 1; c <= 7; c++)
                {
                    for (int d = 1; d <= 7; d++)
                    {
                        for (int e = 1; e <= 7; e++)
                        {
                            for (int f = 1; f <= 7; f++)
                            {
                                for (int g = 1; g <= 7; g++)
                                {
                                    for (int h = 1; h <= 7; h++)
                                    {
                                        int i = sum - a - b - c - d - e - f - g - h;
                                        if (i >= 1 && i <= 7)
                                        {
                                            int numABC = a * 100 + b * 10 + c;
                                            int numDEF = d * 100 + e * 10 + f;
                                            int numGHI = g * 100 + h * 10 + i;
                                            int sumDigits = a + b + c + d + e + f + g + h + i;
                                            bool validDiff = (numGHI - numDEF == diff) && (numDEF - numABC == diff);
                                            bool validSumDigits = (sum == sumDigits);
                                            bool validSubNums = (numABC <= numDEF) && (numDEF <= numGHI);

                                            if (validDiff && validSumDigits && validSubNums)
                                            {
                                                validSolution = true;
                                                Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}", a, b, c, d, e, f, g, h, i);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        if (validSolution == false)
        {
            Console.WriteLine("No");
        }
    }
}