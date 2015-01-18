using System;
using System.Threading;

class Garden
{
    //Telerik Academy Exam 1 @ 24 June 2013 Evening
    //Problem 1 – Garden
    static void Main()
    {
        //set the culture to invariant (actually unnecessary)
        Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
        //parse input
        int tomatoSeeds = int.Parse(Console.ReadLine());
        int tomatoArea = int.Parse(Console.ReadLine());
        int cucumberSeeds = int.Parse(Console.ReadLine());
        int cucumberArea = int.Parse(Console.ReadLine());
        int potatoSeeds = int.Parse(Console.ReadLine());
        int potatoArea = int.Parse(Console.ReadLine());
        int carrotSeeds = int.Parse(Console.ReadLine());
        int carrotArea = int.Parse(Console.ReadLine());
        int cabbageSeeds = int.Parse(Console.ReadLine());
        int cabbageArea = int.Parse(Console.ReadLine());
        int beansSeeds = int.Parse(Console.ReadLine());

        //calculate the price of all seeds
        decimal totalSeedsCost = tomatoSeeds * 0.5M + cucumberSeeds * 0.4M +
            potatoSeeds * 0.25M + carrotSeeds * 0.6M + cabbageSeeds * 0.3M + beansSeeds * 0.4M;
        //calculate the area for all plants except beans
        int area = tomatoArea + cucumberArea + potatoArea + carrotArea + cabbageArea;
        //calculate the area left for beans
        int beansArea = 250 - area;

        //print the results
        Console.WriteLine("Total costs: {0:F2}", totalSeedsCost);
        if (beansArea > 0)
        {
            Console.WriteLine("Beans area: {0}", beansArea);
        }
        else if (beansArea == 0)
        {
            Console.WriteLine("No area for beans");
        }
        else if (area > 250)
        {
            Console.WriteLine("Insufficient area");
        }
    }
}