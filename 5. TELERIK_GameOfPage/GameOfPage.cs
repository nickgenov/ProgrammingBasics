using System;

class GameOfPage
{
    //Telerik Academy Exam 1 @ 6 December 2013 Evening
    //Problem 5 – Game of Page
    static void Main()
    {
        int[] tray = new int[16];
        for (int i = 0; i < tray.Length; i++)
        {
            string input = Console.ReadLine();
            tray[i] = BinaryToDecimal(input);
        }

        //counter for the cookies we buy
        int cookiesBought = 0;

        //play the game with Page
        while (true)
        {
            string command = Console.ReadLine();
            if (command == "paypal")
            {
                break;
            }
            else if (command == "what is")
            {
                int row = int.Parse(Console.ReadLine());
                int col = int.Parse(Console.ReadLine());

                if ((tray[row] & (1 << (15 - col))) == 0)
                {
                    Console.WriteLine("smile");
                }
                else
                {
                    int pos = Math.Abs(col - 14);
                    int mask = 7;

                    //calculate each cookie row
                    //if the row is out of the tray, it is 0
                    int row1 = 0;
                    if (row > 0)
                    {
                        row1 = (tray[row - 1] >> pos) & mask;
                    }
                    int row2 = (tray[row] >> pos) & mask;
                    if (col > 14)
                    {
                        row2 = tray[row] & mask;
                    }
                    int row3 = 0;
                    if (row < 15)
                    {
                        row3 = (tray[row + 1] >> pos) & mask;
                    }

                    //check each case
                    if (row1 == 7 && row2 == 7 && row3 == 7)
                    {
                        Console.WriteLine("cookie");
                    }
                    else if (row1 == 0 && row2 > 0 && row3 == 0)
                    {
                        Console.WriteLine("cookie crumb");
                    }
                    else if ((row1 > 0 || row2 > 0) || row3 > 0)
                    {
                        Console.WriteLine("broken cookie");
                    }
                }
            }
            else if (command == "buy")
            {
                int row = int.Parse(Console.ReadLine());
                int col = int.Parse(Console.ReadLine());

                if ((tray[row] & (1 << (15 - col))) == 0)
                {
                    Console.WriteLine("smile");
                }
                else
                {
                    int pos = Math.Abs(col - 14);
                    int mask = 7;

                    //calculate each cookie row
                    //if the row is out of the tray, it is 0
                    int row1 = 0;
                    if (row > 0)
                    {
                        row1 = (tray[row - 1] >> pos) & mask;
                    }
                    int row2 = (tray[row] >> pos) & mask;
                    int row3 = 0;
                    if (row < 15)
                    {
                        row3 = (tray[row + 1] >> pos) & mask;
                    }

                    //check each case
                    if (row1 == 7 && row2 == 7 && row3 == 7)
                    {
                        //buy the cookie - set the bits to 0
                        tray[row - 1] = tray[row - 1] & ~(mask << pos);
                        tray[row] = tray[row] & ~(mask << pos);
                        tray[row + 1] = tray[row + 1] & ~(mask << pos);
                        //increase the counter
                        cookiesBought++;
                    }
                    else if ((row1 > 0 || row2 > 0) || row3 > 0)
                    {
                        Console.WriteLine("page");
                    }
                }
            }
            //print to test
            for (int i = 0; i < 15; i++)
            {
                //Console.WriteLine(Convert.ToString(tray[i], 2).PadLeft(16, '0'));
            }
        }
        decimal moneyOwed = cookiesBought * 1.79M;
        Console.WriteLine("{0:F2}", moneyOwed);
    }
    public static int BinaryToDecimal(string input)
    {
        int value = 0;
        int power = 0;
        for (int i = 15; i >= 0; i--)
        {
            int bit = int.Parse(Convert.ToString(input[i]));
            value += bit * (int)Math.Pow(2, power);
            power++;
        }
        return value;
    }
}