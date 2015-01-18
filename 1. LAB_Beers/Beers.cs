using System;

class Beers
{
    //C# Basics December 2014 Lab
    static void Main()
    {
        int totalBeers = 0;

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "End")
            {
                break;
            }
            else
            {
                string[] beerInput = SplitString(input);
                int count = int.Parse(beerInput[0]);
                string measure = beerInput[1];
                if (measure == "beers")
                {
                    totalBeers += count;
                }
                else if (measure == "stacks")
                {
                    totalBeers += count * 20;
                }
            }
        }
        int stacks = totalBeers / 20;
        int beers = totalBeers % 20;
        
        Console.WriteLine("{0} stacks + {1} beers", stacks, beers);
    }
    public static string[] SplitString(string input)
    {
        string[] split = input.Split(' ');
        return split;
    }
}