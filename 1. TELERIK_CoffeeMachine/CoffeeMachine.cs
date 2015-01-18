using System;

class CoffeeMachine
{
    //Telerik Academy Exam 1 @ 23 June 2013
    //Problem 1 – Coffee Vending Machine
    static void Main()
    {
        //parse input
        int coins05 = int.Parse(Console.ReadLine());
        int coins10 = int.Parse(Console.ReadLine());
        int coins20 = int.Parse(Console.ReadLine());
        int coins50 = int.Parse(Console.ReadLine());
        int coins100 = int.Parse(Console.ReadLine());
        decimal moneyAmount = decimal.Parse(Console.ReadLine());
        decimal drinkPrice = decimal.Parse(Console.ReadLine());

        //how much money is in the machine
        decimal machineMoney = (coins05 * 0.05M) + (coins10 * 0.10M) 
            + (coins20 * 0.20M) + (coins50 * 0.50M) + (coins100 * 1);
        //the change the machine has to return
        decimal change = moneyAmount - drinkPrice;

        //three cases for the output
        if (moneyAmount < drinkPrice)
        {
            decimal result = drinkPrice - moneyAmount;
            Console.WriteLine("More {0:F2}", result);
        }
        else if ((moneyAmount >= drinkPrice) && (machineMoney >= change))
        {
            decimal result = machineMoney - change;
            Console.WriteLine("Yes {0:F2}", result);
        }
        else
        {
            decimal insufficientMoney = Math.Abs(machineMoney - change);
            Console.WriteLine("No {0:F2}", insufficientMoney);
        }
    }
}