using System;

class BitsInverter
{
    static void Main()
    {
        //parse input
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        //the mask starts from 1000 0000
        //we use XOR to inver the bits
        int mask = 1 << 7;
        //counter for position to change, key to the solution!
        int pos = 1;
        //loop to read n numbers
        for (int count = 0; count < n; count++)
        {
            int num = int.Parse(Console.ReadLine());
            //XOR the bits from the first number
            if (pos <= 8)
            {
                while (mask > 0)
                {
                    num ^= mask;
                    //shift the mask step bits right
                    mask = mask >> step;
                    //add the step to the position counter
                    pos += step;
                }
            }
            if (pos > 8)
            {
                //reduce pos 
                //this way we can skip changing bits if the step is big
                pos -= 8;
                mask = 128 >> (pos - 1);
            }
            //display the result on the console
            Console.WriteLine(num);
        }
    }
}