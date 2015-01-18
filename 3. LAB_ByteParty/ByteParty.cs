using System;

class ByteParty
{
    //C# Basics December 2014 Lab
    static void Main()
    {
        //parse the party numbers
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        //start the party
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "party over")
            {
                //leave the infinite loop when the party ends
                break;
            }
            else
            {
                //split the command string into variables we can use
                string[] splitInput = SplitString(input);
                int command = int.Parse(splitInput[0]);
                int pos = int.Parse(splitInput[1]);

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (command == -1)
                    {
                        //flip the bits with XOR
                        numbers[i] ^= (1 << pos);
                    }
                    else if (command == 0)
                    {
                        //AND an inverted mask - set the bits to 0
                        numbers[i] &= ~(1 << pos);
                    }
                    else if (command == 1)
                    {
                        //OR with 1 - set the bits to 1
                        numbers[i] |= (1 << pos);
                    }
                }
            }
        }
        //print the numbers after the party
        foreach (var num in numbers)
        {
            Console.WriteLine(num);
        }
    }
    public static string[] SplitString(string input)
    {
        string[] split = input.Split(' ');
        return split;
    }
}