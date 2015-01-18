using System;

class PiggyBank
{
    static void Main()
    {
        //parse input
        decimal tankPrice = decimal.Parse(Console.ReadLine());
        int partyDays = int.Parse(Console.ReadLine());

        //the number of normal days in which he saves 2 leva each day
        int normalDays = 30 - partyDays;
        //money saved per month
        int moneySavedPerMonth = normalDays * 2 - partyDays * 5;

        //number of months needed to save enough money for the tank
        int monthsTotal = (int)Math.Ceiling(tankPrice / moneySavedPerMonth);

        //convert the result to years and months
        int months = monthsTotal % 12;
        int years = monthsTotal / 12;

        //print the result on the console
        if (monthsTotal >= 0)
        {
            Console.WriteLine("{0} years, {1} months", years, months);
        }
        else
        {
            Console.WriteLine("never");
        }
    }
}