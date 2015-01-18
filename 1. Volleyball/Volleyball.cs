using System;

class Volleyball
{
    static void Main()
    {
        //parse input
        string year = Console.ReadLine();
        int holidays = int.Parse(Console.ReadLine());
        int hometownWeekends = int.Parse(Console.ReadLine());
        //calculate normal weekends
        int normalWeekends = 48 - hometownWeekends;
        //calculate each kind of play
        decimal normalPlays = 0.75M * normalWeekends;
        decimal hometownPlays = hometownWeekends;
        decimal holidayPlays = holidays * 2.0M / 3;
        //sum result
        decimal totalPlays = normalPlays + hometownPlays + holidayPlays;

        if (year == "leap")
        {
            //increase by 15% in leap years
            totalPlays *= 1.15M;
            //cast to int to cut off after the decimal point
            //alternative to Math.Floor
            Console.WriteLine("{0}", (int)totalPlays);
        }
        else
        {
            //result for normal years
            Console.WriteLine("{0}", (int)totalPlays);
        }
    }
}