using System;
using System.Threading;
class ExamSchedule
{
    static void Main()
    {
        //set culture to en-US
        Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        //parse input
        int startHour = int.Parse(Console.ReadLine());
        int startMinutes = int.Parse(Console.ReadLine());
        string partOfDay = Console.ReadLine();
        int durationHours = int.Parse(Console.ReadLine());
        int durationMinutes = int.Parse(Console.ReadLine());
        //assemble the start time in a string
        string startTime = startHour + ":" + startMinutes + " " + partOfDay;
        //parse it into a start date variable
        DateTime start = DateTime.Parse(startTime);
        //calculate the timespan of the exam
        TimeSpan duration = new TimeSpan(durationHours, durationMinutes, 0);
        //add the timespan to the start
        DateTime end = start + duration;
        //display the result in the required format
        Console.WriteLine("{0:hh:mm:tt}", end);
    }
}