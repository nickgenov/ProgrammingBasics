using System;

class BitFlipper
{
    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());
        //start from left to right
        for (int i = 63; i >= 2; i--)
        {
            //get the three bits next to each other
            ulong firstBit = (number >> i) & 1;
            ulong secondBit = (number >> (i - 1)) & 1;
            ulong thirdBit = (number >> (i - 2)) & 1;

            //see if they are the same
            if (firstBit == secondBit && secondBit == thirdBit)
            {
                //xor inverts the three bits, 7 = 111 in binary
                number ^= (ulong)7 << (i - 2);
                //important! skip 2 bits to get a correct result
                i -= 2;
            }
        }
        //display result
        Console.WriteLine(number);
    }
}