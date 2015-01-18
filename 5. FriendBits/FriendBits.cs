using System;

class JumpingSums
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());
        uint friendBits = 0;
        uint aloneBits = 0;
        //check number from right to left
        for (int index = 31; index >= 0; index--)
        {
            //check current bit
            uint currentBit = (number >> index) & 1;

            //check if there is a left bit and 
            //if it is the same as the current bit
            bool hasLeftBit = index < 31;
            uint leftBit = number >> (index + 1) & 1;
            bool sameLeftBit = (hasLeftBit == true && leftBit == currentBit);

            //check if there is a right bit and 
            //if it is the same as the current bit
            bool hasRightBit = index > 0;
            uint rightBit = number >> (index - 1) & 1;
            bool sameRightBit = (hasRightBit == true && rightBit == currentBit);

            if (sameLeftBit || sameRightBit)
            {
                //if a friend bit is found, add it to the end
                friendBits = (friendBits << 1) | currentBit;
            }
            else
            {
                //alone bit, add it to the end
                aloneBits = (aloneBits << 1) | currentBit;
            }
        }
        Console.WriteLine(friendBits);
        Console.WriteLine(aloneBits);
    }
}

