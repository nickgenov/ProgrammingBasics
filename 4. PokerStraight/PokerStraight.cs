using System;

class PokerStraight
{
    static void Main()
    {
        //read the target weight
        int targetWeight = int.Parse(Console.ReadLine());
        //counter to increase each time we find a hand with the target weight
        int handsCount = 0;
        //loop through all card combinations
        for (int face = 1; face <= 10; face++)
        {
            for (int suit1 = 1; suit1 <= 4; suit1++)
            {
                for (int suit2 = 1; suit2 <= 4; suit2++)
                {
                    for (int suit3 = 1; suit3 <= 4; suit3++)
                    {
                        for (int suit4 = 1; suit4 <= 4; suit4++)
                        {
                            for (int suit5 = 1; suit5 <= 4; suit5++)
                            {
                                //the cards must be consequtive, so
                                //we add 1 to the face of the previous card
                                int weight1 = 10 * (face + 0) + suit1;
                                int weight2 = 20 * (face + 1) + suit2;
                                int weight3 = 30 * (face + 2) + suit3;
                                int weight4 = 40 * (face + 3) + suit4;
                                int weight5 = 50 * (face + 4) + suit5;

                                //calculate the current hand weight
                                int handWeight = weight1 + weight2 + weight3 + weight4 + weight5;

                                //increase the counter
                                if (handWeight == targetWeight)
                                {
                                    handsCount++;
                                }
                            }
                        }
                    }
                }
            }
        }
        //print the result
        Console.WriteLine(handsCount);
    }
}