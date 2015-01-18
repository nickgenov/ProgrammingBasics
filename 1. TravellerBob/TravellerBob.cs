using System;

class TravellerBob
{
    static void Main()
    {
        //parse input
        string yearType = Console.ReadLine();
        int contractMonths = int.Parse(Console.ReadLine());
        int familyMonths = int.Parse(Console.ReadLine());

        //calculate the number of normal months
        int normalMonths = 12 - contractMonths - familyMonths;

        //calculate the number of travels for each month type
        decimal contractMonthsTravels = (4 * contractMonths) * 3;
        decimal familyMonthsTravels = (2 * familyMonths) * 2;
        decimal normalMonthsTravels = (12 * normalMonths) * (3.0M / 5);

        //sum all the travels
        decimal totalTravels = contractMonthsTravels + familyMonthsTravels + normalMonthsTravels;
        //add 5% if the year is leap
        if (yearType == "leap")
        {
            totalTravels *= 1.05M;
        }

        //round down the result
        int result = (int)Math.Floor(totalTravels);

        //print the result
        Console.WriteLine(result);
    }
}