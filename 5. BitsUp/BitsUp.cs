using System;

class BitsUp
{
    static void Main()
    {
        //parse input
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        //set up starting mask
        int mask = 1 << 6;
        //variable for keeping track of
        //the position we have to change
        int pos = 1;
        //loop for parsing n numbers and changing them
        for (int count = 0; count < n; count++)
        {
            int num = int.Parse(Console.ReadLine());
            //if step is a large number, e.g. 20
            //this ensures that we skip a number if necessary
            if (pos <= 7)
            {
                //loop and change bits where needed
                while (pos <= 7)
                {
                    num |= mask;
                    mask = mask >> step;
                    pos += step;
                }
            }
            //update pos and make a new mask
            if (pos > 7)
            {
                pos -= 8;
                mask = 128 >> pos;
            }
            //display result
            Console.WriteLine(num);
        }
    }
}