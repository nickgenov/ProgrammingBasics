using System;

class BitRoller
{
    static void Main()
    {
        //parse the input
        int n = int.Parse(Console.ReadLine());
        int f = int.Parse(Console.ReadLine());
        int r = int.Parse(Console.ReadLine());

        //get the bit value at position #f
        int bit = (n >> f) & 1;
        //remove bit #f and make a new 18 bit number
        //get the bits after #f
        int bitsAfterF = n & (int)(Math.Pow(2, f) - 1);
        //get the bits before #f
        int mask = (int)(Math.Pow(2, 18 - f) - 1) << (f + 1);
        int bitsBeforeF = n & mask;
        //assemble the number to roll
        int numberToRoll = (bitsBeforeF >> 1) | bitsAfterF;
        //roll the new 18 bit number r times
        for (int count = 0; count < r; count++)
        {
            //get the last bit
            int bitRoll = numberToRoll & 1;
            //shift it left 17 positions!
            bitRoll = bitRoll << 17;
            //shift the number right 1 position
            numberToRoll = numberToRoll >> 1;
            //assemble the rolled number
            numberToRoll = bitRoll | numberToRoll;
        }
        //split the rolled number in parts before #f and after #f
        bitsAfterF = numberToRoll & (int)(Math.Pow(2, f) - 1);
        mask = (int)(Math.Pow(2, 18 - f) - 1) << f;
        bitsBeforeF = numberToRoll & mask;
        //assemble the final result
        int result = ((bitsBeforeF << 1) | (bit << f)) | bitsAfterF;
        //display it on the console
        Console.WriteLine(result);
    }
}