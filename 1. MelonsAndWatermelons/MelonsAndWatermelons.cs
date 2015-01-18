using System;

class MelonsAndWatermelons
{
    static void Main()
    {
        //parse input
        int startingDay = int.Parse(Console.ReadLine());
        int numberOfDays = int.Parse(Console.ReadLine());
        //set up variables for counting
        int melonCount = 0;
        int watermelonCount = 0;
        int day = startingDay;
        int count = numberOfDays;
        //count loop
        while (count > 0)
        {
            melonCount += ReturnMelonCount(day);
            watermelonCount += ReturnWatermelonCount(day);
            if (day == 7)
            {
                //weekdays are from 1 to 7
                day = 0;
            }
            //increase the day
            day++;
            //reduce the number of days left
            count--;
        }
        //print the result
        if (watermelonCount > melonCount)
        {
            int difference = watermelonCount - melonCount;
            Console.WriteLine("{0} more watermelons", difference);
        }
        else if (melonCount > watermelonCount)
        {
            int difference = melonCount - watermelonCount;
            Console.WriteLine("{0} more melons", difference);
        }
        else
        {
            Console.WriteLine("Equal amount: {0}", melonCount);
        }
    }
    //methods to calculate the fruit count
    public static int ReturnMelonCount(int day)
    {
        int melonCount = 0;
        switch (day)
        {
            case 2:
            case 5:
            case 6: melonCount = 2;
                break;
            case 3: melonCount = 1;
                break;
        }
        return melonCount;
    }
    public static int ReturnWatermelonCount(int day)
    {
        int watermelonCount = 0;
        switch (day)
        {
            case 1:
            case 3:
            case 6: watermelonCount = 1;
                break;
            case 4:
            case 5: watermelonCount = 2;
                break;
        }
        return watermelonCount;
    }
}