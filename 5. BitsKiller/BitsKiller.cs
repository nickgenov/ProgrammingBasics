using System;
 
class BitsKiller
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
 
        //counter for bits in each number
        //to keep track which bits to extract
        int index = 0;
        //to keep track how many bits are extracted
        int extractedBitCount = 0;
        //to store the result to be printed
        //every 8 extracted bits are printed as a decimal number
        int result = 0;
 
        //parse n numbers
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            //for loop starting from 7, which is the max << for an 8 bit number
            //to get to the first bit and change it, if necessary
            for (int bit = 7; bit >= 0; bit--)
            {
                //KEY PART OF THE SOLUTION!!!
                //if index % step == 1 we change the bit to 1
                //example: step 1, 1 + 5, 1 + 10, 1 + 15
                //the second index % step (1 % 5 = 1), so we change bit at pos # 6
                //next when index = 11, index % 5 = 1, so we change bit # 11
                //and so on
                //step == 1 && index > 0
                //this is because the remainder of % 1 is always 0
                //so we can't change bits with step 1 with the first if expression
                //index > 0 is because the first bit is never changed, so we have to skip it
                bool condition = (index % step == 1) || (step == 1 && index > 0);
                //get the bits that are NOT KILLED and store them
                //this is some of the other problems in REVERSE
                if (condition == false)
                {
                    //extract the bits not killed one by one
                    int extractedBit = (number & (1 << bit)) >> bit;
                    //increase the counter for extracted bits
                    //when it reaches 8, we print the number
                    extractedBitCount++;
                    //store the extracted bits in this number
                    result = (result << 1) + extractedBit;
                    //when we reach 8 extracted bits, print the result
                    if (extractedBitCount % 8 == 0)
                    {
                        Console.WriteLine(result);
                        //reset the result for storing the next bits
                        result = 0;
                    }
                }
                //increase the index counter so we know 
                //when it is time extract the next bit
                index++;
            }
        }
        if (extractedBitCount % 8 != 0)
        {
            //see how many zeroes we have to add to the right side of the number
            int padZeroesCount = 8 - (extractedBitCount % 8);
            //add the correct number of zeroes to the right
            result = result << padZeroesCount;
            //print the last result!
            Console.WriteLine(result);
        }
    }
}