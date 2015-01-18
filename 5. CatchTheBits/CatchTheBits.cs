using System;

class CatchTheBits
{
    static void Main()
    {
        //parse input
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        //set up variables for the task
        int pos = 2;
        int mask = 1 << 6;
        int result = 0;
        int bitCount = 0;
        //loop n times to read numbers to process
        for (int count = 0; count < n; count++)
        {
            int num = int.Parse(Console.ReadLine());
            //extract bits
            while (pos <= 8)
            {
                //get the extracted bit value
                int bit = (num & mask) >> (8 - pos);
                //make room for the bit in the result
                result = result << 1;
                //add the extracted bit to the last position of the result
                result |= bit;
                //shift the mask step bits
                mask = mask >> step;
                //shift the position
                pos += step;
                //increase the counter for extracted bits
                bitCount++;
                //print whole bytes!
                //IMPORTANT!!! do this in the loop
                //to make sure the found bit count at the end is less than 8
                //and to get a correct result!
                if (bitCount == 8)
                {
                    Console.WriteLine(result);
                    //reset the result and bit counter
                    result = 0;
                    bitCount = 0;
                }
            }
            //if the position is outside the first byte
            if (pos > 8)
            {
                //calculate the position in the new byte
                pos -= 8;
                //calculate the new mask
                mask = 128 >> (pos - 1);
            }
        }
        //pad any leftover bytes with zeroes to get a last byte
        if (bitCount % 8 != 0)
        {
            int trailingZeroes = 8 - (bitCount % 8);
            result = result << trailingZeroes;
            Console.WriteLine(result);
        }
    }
}