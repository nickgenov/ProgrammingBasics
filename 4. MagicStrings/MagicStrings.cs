using System;

class MagicStrings
{
    static void Main()
    {
        //array for the letters, in alphabetical order
        char[] letters = { 'k', 'n', 'p', 's' };
        //parse diff
        int diff = int.Parse(Console.ReadLine());
        //variable for found solution
        bool validSolution = false;
        //loop through all combinations of the letters
        for (int a = 0; a < 4; a++)
        {
            for (int b = 0; b < 4; b++)
            {
                for (int c = 0; c < 4; c++)
                {
                    for (int d = 0; d < 4; d++)
                    {
                        for (int e = 0; e < 4; e++)
                        {
                            for (int f = 0; f < 4; f++)
                            {
                                for (int g = 0; g < 4; g++)
                                {
                                    for (int h = 0; h < 4; h++)
                                    {
                                        //assemble first and second word
                                        string wordABCD = "" + letters[a] + letters[b] + letters[c] + letters[d];
                                        string wordEFGH = "" + letters[e] + letters[f] + letters[g] + letters[h];
                                        //use the method to calculate word weight
                                        int weightABCD = CalculateWordWeight(wordABCD);
                                        int weightEFGH = CalculateWordWeight(wordEFGH);
                                        //check if magic string conditions are met
                                        bool validDiff = (weightEFGH - weightABCD == diff) || (weightABCD - weightEFGH == diff);

                                        if (validDiff)
                                        {
                                            //found a solution
                                            validSolution = true;
                                            //display result to the console
                                            Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}", letters[a], letters[b],
                                                letters[c], letters[d], letters[e], letters[f], letters[g], letters[h]);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        //if no solutions are found, print No
        if (validSolution == false)
        {
            Console.WriteLine("No");
        }
    }
    //methods for calculating letter and word weight
    public static int CalculateLetterWeight(char letter)
    {
        int weight = 0;
        switch (letter)
        {
            case 's': weight = 3;
                break;
            case 'n': weight = 4;
                break;
            case 'k': weight = 1;
                break;
            case 'p': weight = 5;
                break;
        }
        return weight;
    }
    public static int CalculateWordWeight(string word)
    {
        int weight = 0;
        for (int i = 0; i < word.Length; i++)
        {
            weight += CalculateLetterWeight(word[i]);
        }
        return weight;
    }
}