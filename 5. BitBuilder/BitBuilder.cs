using System;

class BitBuilder
{
    static void Main()
    {
        //parse the number to change
        long number = long.Parse(Console.ReadLine());

        //the max number of commands is 30, loop 30 times
        for (int count = 0; count < 30; count++)
        {
            //read the first command
            //it's usually the bit position, but can also be "quit"
            string command1 = Console.ReadLine();
            if (command1 == "quit")
            {
                //leave the loop and end execution
                break;
            }
            //parse the second command
            string command2 = Console.ReadLine();
            //store the first command in a position variable
            int pos = int.Parse(command1);
            
            //flip logic
            if (command2 == "flip")
            {
                //XOR inverts the bit at #pos
                number ^= 1 << pos;
            }
            
            //remove logic
            else if (command2 == "remove")
            {
                //store the bits after the removed bit
                long mask = (long)(Math.Pow(2, pos) - 1);
                long bitsAfterPos = number & mask;
                //shift the number #(pos + 1) positions to
                //clear the removed bit and all the bits after it
                //then shift it left #pos positions
                number = (number >> (pos + 1)) << pos;
                //put the stored bits back in the number
                number |= bitsAfterPos;
            }

            //insert logic
            else if (command2 == "insert")
            {
                //store the bits after the inserted bit
                long mask = (long)(Math.Pow(2, pos) - 1);
                long bitsAfterPos = number & mask;
                //clear the bits in the number after #pos
                //and shift it left #(pos + 1) positions to make room for the inserted bit
                number = (number >> pos) << (pos + 1);
                //insert 1 at #pos
                number |= (long)1 << pos;
                //put the stored bits back in the number
                number |= bitsAfterPos;
            }
        }
        //print the changed number!
        Console.WriteLine(number);
    }
}