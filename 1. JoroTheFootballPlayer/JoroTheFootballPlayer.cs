using System;

class JoroTheFootballPlayer
{
    static void Main()
    {
        //parse input
        string yearType = Console.ReadLine();
        int numberOfHolidays = int.Parse(Console.ReadLine());
        int hometownWeekends = int.Parse(Console.ReadLine());
        //calculate normal weekends
        int normalWeekends = 52 - hometownWeekends;
        //calculate number of plays
        decimal normalWeekendPlays = normalWeekends * (2.0M / 3);
        decimal hometownWeekendPlays = hometownWeekends;
        decimal holidayPlays = numberOfHolidays / 2.0M;
        //variable for the total number of played games
        decimal totalPlays = 0;
        //case for leap year
        if (yearType == "t")
        {
            totalPlays = Math.Floor(3 + normalWeekendPlays + hometownWeekendPlays + holidayPlays);
        }
        //case for non-leap year
        else if (yearType == "f")
        {
            totalPlays = Math.Floor(normalWeekendPlays + hometownWeekendPlays + holidayPlays);
        }
        //display result
        Console.WriteLine(totalPlays);
    }
}