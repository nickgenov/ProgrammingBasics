using System;

class BatGoikoTower
{
    //Telerik Academy Exam 1 @ 24 June 2013 Evening
    //Problem 4 – Bat’Goiko Tower
    static void Main()
    {
        //parse input
        int n = int.Parse(Console.ReadLine());

        //variables for counting
        int dotCount = n - 1;
        int middleCount = 0;
        int currentRow = 0;

        //loop to print all rows
        while (dotCount >= 0)
        {
            Console.Write(new string('.', dotCount) + '/');
            //if a crossbeam row is reached, print dashes
            bool dashRow = false;
            if (currentRow == 1 || currentRow == 3 || currentRow == 6 || currentRow == 10 || currentRow == 15
                || currentRow == 21 || currentRow == 28 || currentRow == 36)
            {
                dashRow = true;
            }
            if (dashRow)
            {
                Console.Write(new string('-', middleCount));
            }
            else
            {
                Console.Write(new string('.', middleCount));
            }
            Console.WriteLine('\\' + new string('.', dotCount));
            dotCount--;
            middleCount += 2;
            currentRow++;
        }
    }
}