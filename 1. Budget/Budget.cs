using System;

class Budget
{
    static void Main()
    {
        //parse input
        decimal budget = decimal.Parse(Console.ReadLine());
        decimal weekdaysOut = decimal.Parse(Console.ReadLine());
        decimal hometownWeekends = decimal.Parse(Console.ReadLine());
        //a month has 30 days and 4 weekends
        int weekdays = 22;
        int weekendDays = 8;

        //weekday expenses
        decimal weekdaysExpenses = weekdays * 10;
        //weekdays out expenses
        decimal weekdaysOutExpenses = Math.Floor(0.03M * budget) * weekdaysOut;
        //weekends not in hometown
        decimal weekendExpenses = 20 * (weekendDays - hometownWeekends * 2);
        //rent
        decimal rent = 150;
        //total expenses
        decimal totalExpenses = weekdaysExpenses + weekdaysOutExpenses + weekendExpenses + rent;
        //difference
        decimal difference = Math.Abs(budget - totalExpenses);

        //display result
        if (totalExpenses < budget)
        {
            Console.WriteLine("Yes, leftover {0}.", difference);
        }
        else if (totalExpenses > budget)
        {
            Console.WriteLine("No, not enough {0}.", difference);
        }
        else
        {
            Console.WriteLine("Exact Budget.");
        }
    }
}