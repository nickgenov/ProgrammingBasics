using System;
using System.Linq;

class WeirdCombinations
{
    static void Main()
    {
        //parse input
        string sequence = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());
        //stores if a solution is found
        bool validSolution = false;
        //starts from -1, because the first sequence is number 0
        int count = -1;
        //loop through all sequences in order
        for (int a = 0; a <= 4; a++)
        {
            for (int b = 0; b <= 4; b++)
            {
                for (int c = 0; c <= 4; c++)
                {
                    for (int d = 0; d <= 4; d++)
                    {
                        for (int e = 0; e <= 4; e++)
                        {
                            count++;
                            if (count == n)
                            {
                                validSolution = true;
                                Console.WriteLine("{0}{1}{2}{3}{4}", sequence[a], 
                                    sequence[b], sequence[c], sequence[d], sequence[e]);
                            }
                        }
                    }
                }
            }
        }
        //if no solution was found
        if (!validSolution)
        {
            Console.WriteLine("No");
        }
    }
}