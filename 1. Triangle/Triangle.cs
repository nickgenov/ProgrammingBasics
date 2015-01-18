using System;

class Triangle
{
    static void Main()
    {
        //parse point coordinates
        double aX = double.Parse(Console.ReadLine());
        double aY = double.Parse(Console.ReadLine());
        double bX = double.Parse(Console.ReadLine());
        double bY = double.Parse(Console.ReadLine());
        double cX = double.Parse(Console.ReadLine());
        double cY = double.Parse(Console.ReadLine());
        //calculate distance between points
        double a = DistanceBetweenPoints(aX, aY, bX, bY);
        double b = DistanceBetweenPoints(bX, bY, cX, cY);
        double c = DistanceBetweenPoints(aX, aY, cX, cY);
        //check if the sides can form a triangle
        bool canFormTriangle = (a + b > c) && (b + c > a) && (a + c > b);
        //display results
        if (canFormTriangle)
        {
            //calculate triangle area
            double area = CalculateTriangleArea(a, b, c);
            Console.WriteLine("Yes");
            Console.WriteLine("{0:F2}", area);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("{0:F2}", a);
        }
    }
    public static double DistanceBetweenPoints(double aX, double aY, double bX, double bY)
    {
        double distance = Math.Sqrt(Math.Pow((bX - aX), 2) + Math.Pow((bY - aY), 2));
        return distance;
    }
    public static double CalculateTriangleArea(double a, double b, double c)
    {
        double p = (a + b + c) / 2;
        double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        return area;
    }
}