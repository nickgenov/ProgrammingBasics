using System;

class InsideTheBuilding
{
    static void Main()
    {
        //parse input
        int h = int.Parse(Console.ReadLine());

        int x1 = int.Parse(Console.ReadLine());
        int y1 = int.Parse(Console.ReadLine());
        int x2 = int.Parse(Console.ReadLine());
        int y2 = int.Parse(Console.ReadLine());
        int x3 = int.Parse(Console.ReadLine());
        int y3 = int.Parse(Console.ReadLine());
        int x4 = int.Parse(Console.ReadLine());
        int y4 = int.Parse(Console.ReadLine());
        int x5 = int.Parse(Console.ReadLine());
        int y5 = int.Parse(Console.ReadLine());

        //use the method to display result
        CheckPoint(x1, y1, h);
        CheckPoint(x2, y2, h);
        CheckPoint(x3, y3, h);
        CheckPoint(x4, y4, h);
        CheckPoint(x5, y5, h);
    }
    //method using if statements to check the points
    public static void CheckPoint(int x, int y, int h)
    {
        if ((x >= 0 && x <= (3 * h) && y >= 0 && y <= h)
      || (x >= h && x <= (2 * h) && y >= h && y <= (4 * h)))
        {
            Console.WriteLine("inside");
        }
        else
        {
            Console.WriteLine("outside");
        }
    }
}