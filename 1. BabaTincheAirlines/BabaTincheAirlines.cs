using System;

class BabaTincheAirlines
{
    static void Main()
    {
        //first class
        string input = Console.ReadLine();
        int[] array = SplitInput(input);
        int firstClassPassengers = array[0];
        int frequentFlyers = array[1];
        int mealPurchases = array[2];
        decimal incomeFirstClass = (firstClassPassengers - frequentFlyers - mealPurchases) * 7000 +
            frequentFlyers * (0.3M * 7000) + mealPurchases * 1.005M * 7000;
        //business class
        input = Console.ReadLine();
        array = SplitInput(input);
        int businessClassPassengers = array[0];
        frequentFlyers = array[1];
        mealPurchases = array[2];
        decimal incomeBusinessClass = (businessClassPassengers - frequentFlyers - mealPurchases) * 3500 +
            frequentFlyers * (0.3M * 3500) + mealPurchases * 1.005M * 3500;
        //economy class
        input = Console.ReadLine();
        array = SplitInput(input);
        int economyClassPassengers = array[0];
        frequentFlyers = array[1];
        mealPurchases = array[2];
        decimal incomeEconomyClass = (economyClassPassengers - frequentFlyers - mealPurchases) * 1000 +
           frequentFlyers * (0.3M * 1000) + mealPurchases * 1.005M * 1000;
        //max possible income - all seats taken, no frequent flyers, everyone purchases a meal
        decimal maxIncome = (12 * 7000 + 28 * 3500 + 50 * 1000) * 1.005M;
        //actual income
        int income = (int)(incomeFirstClass + incomeBusinessClass + incomeEconomyClass);
        //difference
        decimal difference = (int)(maxIncome - income);
        //display result
        Console.WriteLine("{0}", income);
        Console.WriteLine("{0}", difference);
    }
    public static int[] SplitInput(string input)
    {
        string[] array = input.Split(' ');
        int[] result = new int[array.Length];
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = int.Parse(array[i]);
        }
        return result;
    }
}