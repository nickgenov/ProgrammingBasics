using System;

class NextDate
{
    //Telerik Academy Exam 1 @ 27 Dec 2012
    //Problem 1 – Next Date
    static void Main()
    {
        //parse input
        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());

        //convert the input to DateTime
        DateTime date = new DateTime(year, month, day);
        //add 1 day 
        date = date.AddDays(1);

        //print the result in a formatted string
        Console.WriteLine("{0:d.M.yyyy}", date);
    }
}