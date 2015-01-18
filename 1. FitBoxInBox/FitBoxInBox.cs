using System;

class FitBoxInBox
{
    static void Main()
    {
        //parse box dimentions
        int widthA = int.Parse(Console.ReadLine());
        int heightA = int.Parse(Console.ReadLine());
        int depthA = int.Parse(Console.ReadLine());

        int widthB = int.Parse(Console.ReadLine());
        int heightB = int.Parse(Console.ReadLine());
        int depthB = int.Parse(Console.ReadLine());

        //first case - check if the first box fits in the second box
        if (widthA > widthB && heightA > heightB && depthA > depthB)
        {
            Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})",
                widthB, heightB, depthB, widthA, heightA, depthA);
        }
        if (widthA > widthB && depthA > heightB && heightA > depthB)
        {
            Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})",
                widthB, heightB, depthB, widthA, depthA, heightA);
        }
        if (heightA > widthB && widthA > heightB && depthA > depthB)
        {
            Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})",
                widthB, heightB, depthB, heightA, widthA, depthA);
        }
        if (heightA > widthB && depthA > heightB && widthA > depthB)
        {
            Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})",
                widthB, heightB, depthB, heightA, depthA, widthA);
        }
        if (depthA > widthB && widthA > heightB && heightA > depthB)
        {
            Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})",
                widthB, heightB, depthB, depthA, widthA, heightA);
        }
        if (depthA > widthB && heightA > heightB && widthA > depthB)
        {
            Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})",
                widthB, heightB, depthB, depthA, heightA, widthA);
        }
        //second case - check if the second box fits in the first box
        if (widthB > widthA && heightB > heightA && depthB > depthA)
        {
            Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})",
                widthA, heightA, depthA, widthB, heightB, depthB);
        }
        if (widthB > widthA && depthB > heightA && heightB > depthA)
        {
            Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})",
                widthA, heightA, depthA, widthB, depthB, heightB);
        }
        if (heightB > widthA && widthB > heightA && depthB > depthA)
        {
            Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})",
                widthA, heightA, depthA, heightB, widthB, depthB);
        }
        if (heightB > widthA && depthB > heightA && widthB > depthA)
        {
            Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})",
                widthA, heightA, depthA, heightB, depthB, widthB);
        }
        if (depthB > widthA && widthB > heightA && heightB > depthA)
        {
            Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})",
                widthA, heightA, depthA, depthB, widthB, heightB);
        }
        if (depthB > widthA && heightB > heightA && widthB > depthA)
        {
            Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})",
                widthA, heightA, depthA, depthB, heightB, widthB);
        }
    }
}

