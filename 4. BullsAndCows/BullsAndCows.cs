using System;

class BullsAndCows
{
    static void Main()
    {
        //parse the secret number as a string
        string secretNum = Console.ReadLine();
        //store its digits in an array of integers
        int[] secret = new int[secretNum.Length];
        for (int i = 0; i < secret.Length; i++)
        {
            secret[i] = int.Parse(Convert.ToString(secretNum[i]));
        }
        //parse the bulls and cows count
        int bulls = int.Parse(Console.ReadLine());
        int cows = int.Parse(Console.ReadLine());

        //use this variable to store if a solution was found
        bool validSolution = false;

        //loop through all number combinations
        for (int a = 1; a <= 9; a++)
        {
            for (int b = 1; b <= 9; b++)
            {
                for (int c = 1; c <= 9; c++)
                {
                    for (int d = 1; d <= 9; d++)
                    {
                        //put the guess number in an array
                        int[] guess = { a, b, c, d };
                        //copy the secret number in a new array
                        int[] check = new int[secret.Length];
                        for (int i = 0; i < check.Length; i++)
                        {
                            check[i] = secret[i];
                        }
                        //check for bulls
                        int guessBulls = 0;
                        for (int i = 0; i < guess.Length; i++)
                        {
                            if (check[i] == guess[i])
                            {
                                guessBulls++;
                                //IMPORTANT! update the values so they are not counted again
                                check[i] = -2;
                                guess[i] = -2;
                            }
                        }
                        //check for cows
                        int guessCows = 0;
                        for (int i = 0; i < guess.Length; i++)
                        {
                            for (int j = 0; j < guess.Length; j++)
                            {
                                //IMPORTANT! bull digits must be excluded, they are = -2
                                //check if GREATER THAN ZERO to make sure we don't count twice
                                if (i != j && check[i] > 0 && check[i] == guess[j])
                                {
                                    guessCows++;
                                    //update the values so the digits are not counted in other cows
                                    guess[j] = -1;
                                    check[i] = -1;
                                }
                            }
                        }
                        //compare the bulls and cows in the current number
                        //to the ones in the input
                        if ((bulls == guessBulls) && (cows == guessCows))
                        {
                            validSolution = true;
                            //print result
                            Console.Write("{0}{1}{2}{3} ", a, b, c, d);
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