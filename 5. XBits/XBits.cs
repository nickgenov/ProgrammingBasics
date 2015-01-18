using System;

class XBits
{
    static void Main()
    {
        //store the 8 numbers in an array
        int[] numbers = new int[8];
        for (int count = 0; count < 8; count++)
        {
            //parse each number in the array
            numbers[count] = int.Parse(Console.ReadLine());
        }
        //counter for the found X-bits
        int xBitCount = 0;
        //check the 8 numbers
        for (int index = 0; index <= 5; index++)
        {
            //three numbers to check
            int num1 = numbers[index];
            int num2 = numbers[index + 1];
            int num3 = numbers[index + 2];
            //loop that checks the three numbers for X-bits
            for (int pos = 0; pos <= 29; pos++)
            {
                //get the value of three bits at the same position
                int bits1 = (num1 >> pos) & 7;
                int bits2 = (num2 >> pos) & 7;
                int bits3 = (num3 >> pos) & 7;
                //5 is 101, 2 is 010
                bool xBitNumber = (bits1 == 5) && (bits2 == 2) && (bits3 == 5);
                //if a number is found, increase the counter
                if (xBitNumber)
                {
                    xBitCount++;
                }
            }
        }
        //display the result
        Console.WriteLine(xBitCount);
    }
}