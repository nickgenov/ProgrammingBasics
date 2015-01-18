using System;

class HayvanNumbers
{
    static void Main()
    {
        //parse input
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
        //variable for checking if there is a solution
        bool validSolution = false;
        //loop that goes through all combinations
        for (int a = 5; a <= 9; a++)
        {
            for (int b = 5; b <= 9; b++)
            {
                for (int c = 5; c <= 9; c++)
                {
                    for (int d = 5; d <= 9; d++)
                    {
                        for (int e = 5; e <= 9; e++)
                        {
                            for (int f = 5; f <= 9; f++)
                            {
                                for (int g = 5; g <= 9; g++)
                                {
                                    for (int h = 5; h <= 9; h++)
                                    {
                                        //we don't need to loop i, we can calculate it
                                        //to speed things up
                                        int i = sum - a - b - c - d - e - f - g - h;
                                        //check if i is valid
                                        if (i >= 5 && i <= 9)
                                        {
                                            //calculate the sub numbers with the method
                                            int numABC = CalculateSubNumber(a, b, c);
                                            int numDEF = CalculateSubNumber(d, e, f);
                                            int numGHI = CalculateSubNumber(g, h, i);

                                            //boolean variables for each condition
                                            bool validDiff = (numGHI - numDEF == diff) && (numDEF - numABC == diff);
                                            bool validSum = (a + b + c + d + e + f + g + h + i == sum);
                                            bool validSubNums = (numABC <= numDEF) && (numDEF <= numGHI);
                                            //boolean variable for all conditions
                                            bool hayvanNumber = validDiff && validSum && validSubNums;

                                            if (hayvanNumber)
                                            {
                                                //found a solution
                                                validSolution = true;
                                                //display the result
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
        //if no solutions are found
        if (validSolution == false)
        {
            Console.WriteLine("No");
        }
    }
    public static int CalculateSubNumber(int a, int b, int c)
    {
        int subNumberValue = a * 100 + b * 10 + c;
        return subNumberValue;
    }
}