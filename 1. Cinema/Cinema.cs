using System;

class Cinema
{
    static void Main()
    {
        //parse input
        string type = Console.ReadLine();
        int rows = int.Parse(Console.ReadLine());
        int columns = int.Parse(Console.ReadLine());
        //calculate the number of seats
        int seats = rows * columns;
        //variable for the income to be printed
        decimal income = 0;
        //if statements for each projection type
        if (type == "Premiere")
        {
            income = seats * 12;
        }
        else if (type == "Normal")
        {
            income = seats * 7.5M;
        }
        else if (type == "Discount")
        {
            income = seats * 5;
        }
        //display result
        Console.WriteLine("{0:F2} leva", income);
    }
}