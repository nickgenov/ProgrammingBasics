using System;

class NewHouse
{
    static void Main()
    {
        //parse input
        int n = int.Parse(Console.ReadLine());
        //print top
        Console.WriteLine(new string('-', (n - 1) / 2) + '*' + new string('-', (n - 1) / 2));
        //print roof
        int dashCount = (n - 3) / 2;
        int starCount = 3;
        while (dashCount >= 0)
        {
            Console.WriteLine(new string('-', dashCount) + new string('*', starCount) + new string('-', dashCount));
            dashCount--;
            starCount += 2;
        }
        //print wall
        starCount = n - 2;
        int rowCount = n;
        while (rowCount > 0)
        {
            Console.WriteLine('|' + new string('*', starCount) + '|');
            rowCount--;
        }
    }
}