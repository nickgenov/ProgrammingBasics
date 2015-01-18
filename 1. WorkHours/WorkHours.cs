using System;

class WorkHours
{
    static void Main()
    {
        //parse input
        int hoursNeeded = int.Parse(Console.ReadLine());
        int days = int.Parse(Console.ReadLine());
        double productivity = int.Parse(Console.ReadLine());
        //calculate the effective work hours
        double workHours = Math.Floor((0.9 * 12 * days) * (productivity / 100));
        //calculate the difference
        double difference = workHours - hoursNeeded;
        //display the result
        if (hoursNeeded <= workHours)
        {
            Console.WriteLine("Yes");
        }
        else if (hoursNeeded > workHours)
        {
            Console.WriteLine("No");
        }
        Console.WriteLine("{0}", difference);
    }
}