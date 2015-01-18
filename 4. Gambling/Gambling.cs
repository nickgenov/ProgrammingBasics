using System;

class Gambling
{
    static void Main()
    {
        //parse input
        decimal cash = decimal.Parse(Console.ReadLine());
        string houseHand = Console.ReadLine();
        //set up counters for each hand
        decimal winningHands = 0;
        decimal totalHands = 0;
        //loop through all card combinations
        for (int a = 2; a <= 14; a++)
        {
            for (int b = 2; b <= 14; b++)
            {
                for (int c = 2; c <= 14; c++)
                {
                    for (int d = 2; d <= 14; d++)
                    {
                        //calculate the current hand strength
                        int handStrength = a + b + c + d;
                        //increase the total hands count
                        totalHands++;
                        //calculate the house hand strength with the method
                        int houseHandStrength = ReturnHouseHandStrength(houseHand);
                        //if the current hand is stronger, increase the counter
                        if (handStrength > houseHandStrength)
                        {
                            winningHands++;
                        }
                    }
                }
            }
        }
        //calculate variables
        decimal chanceToWin = (winningHands / totalHands) * 100;
        decimal potAmount = 2 * cash;
        decimal expectedWinnings = (chanceToWin * potAmount) / 100;
        //display result
        if (chanceToWin < 50)
        {
            Console.WriteLine("FOLD");
        }
        else
        {
            Console.WriteLine("DRAW");
        }
        Console.WriteLine("{0:F2}", expectedWinnings);
    }
    //methods for calculating the house hand strength
    public static int ReturnHouseHandStrength(string houseHand)
    {
        int strength = 0;
        string[] cards = houseHand.Split(' ');
        foreach (var card in cards)
        {
            strength += ReturnCardStrength(card);
        }
        return strength;
    }
    public static int ReturnCardStrength(string card)
    {
        int strength = 0;
        switch (card)
        {
            case "2": strength = 2;
                break;
            case "3": strength = 3;
                break;
            case "4": strength = 4;
                break;
            case "5": strength = 5;
                break;
            case "6": strength = 6;
                break;
            case "7": strength = 7;
                break;
            case "8": strength = 8;
                break;
            case "9": strength = 9;
                break;
            case "10": strength = 10;
                break;
            case "J": strength = 11;
                break;
            case "Q": strength = 12;
                break;
            case "K": strength = 13;
                break;
            case "A": strength = 14;
                break;
        }
        return strength;
    }
}