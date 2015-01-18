using System;

class Electricity
{
    static void Main()
    {
        //parse input
        int floors = int.Parse(Console.ReadLine());
        int flats = int.Parse(Console.ReadLine());
        DateTime time = DateTime.Parse(Console.ReadLine());

        double lampPower = 100.53;
        double computerPower = 125.90;
        int totalFlats = floors * flats;
        double totalPowerConsumption = 0;

        //compare time to the periods, key to the solution!
        if (time >= Convert.ToDateTime("14:00") && time <= Convert.ToDateTime("18:59"))
        {
            //From 14:00 to 18:59 - 2 lamps + 2 computers are running
            totalPowerConsumption = totalFlats * (2 * lampPower + 2 * computerPower);
        }
        else if (time >= Convert.ToDateTime("19:00") && time <= Convert.ToDateTime("23:59"))
        {
            //From 19:00 to 23:59 - 7 lamps + 6 computers are running
            totalPowerConsumption = totalFlats * (7 * lampPower + 6 * computerPower);
        }
        else if (time >= Convert.ToDateTime("00:00") && time <= Convert.ToDateTime("08:59"))
        {
            //From 00:00 to 08:59 - 1 lamp + 8 computers are running
            totalPowerConsumption = totalFlats * (1 * lampPower + 8 * computerPower);
        }

        //display result to the console
        Console.WriteLine("{0} Watts", (int)totalPowerConsumption);
    }
}