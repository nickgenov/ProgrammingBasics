using System;

class BitSifting
{
    static void Main()
    {
        //parse the number to sift
        ulong number = ulong.Parse(Console.ReadLine());
        //sieves count
        int n = int.Parse(Console.ReadLine());
        //parse the sieves
        for (int count = 0; count < n; count++)
        {
            ulong sieve = ulong.Parse(Console.ReadLine());
            //key to the solution!
            //XOR + AND gets calculates the result
            number = (number ^ sieve) & number;
        }
        //count the 1 bits
        int bitCount = 0;
        int shift = 0;
        int loops = 64;
        while (loops > 0)
        {
            ulong bit = (number >> shift) & 1;
            if (bit == 1)
            {
                bitCount++;
            }
            shift++;
            loops--;
        }
        //display the result
        Console.WriteLine(bitCount);
    }
}