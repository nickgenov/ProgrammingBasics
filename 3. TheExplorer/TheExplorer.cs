using System;

class TheExplorer
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        //first line
        Console.WriteLine(new string('-', n / 2) + '*' + new string('-', n / 2));
        //top half
        int startDash = (n / 2) - 1;
        int middleDash = 1;
        while (startDash >= 0)
        {
            Console.WriteLine(new string('-', startDash) + '*' + new string('-', middleDash) + '*' + new string('-', startDash));
            startDash--;
            middleDash += 2;
        }
        //bottom half
        startDash = 1;
        middleDash = n - 4;
        while (middleDash >= 1)
        {
            Console.WriteLine(new string('-', startDash) + '*' + new string('-', middleDash) + '*' + new string('-', startDash));
            startDash++;
            middleDash -= 2;
        }
        //last line
        Console.WriteLine(new string('-', n / 2) + '*' + new string('-', n / 2));
    }
}