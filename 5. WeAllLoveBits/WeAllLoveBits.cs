using System;

class WeAllLoveBits
{
    static void Main()
    {
        //P ^ (~P) = 1111111111111111, only ones
        //so it is a mask to copy a number, we can ignore it
        //parse number count
        int count = int.Parse(Console.ReadLine());
        for (int i = 0; i < count; i++)
        {
            //parse every number
            uint num = uint.Parse(Console.ReadLine());
            //reverse it with the method
            uint result = ReverseBits(num);
            //display the result
            Console.WriteLine(result);
        }
    }
    //method to count the meaningful bits in a number
    public static int BitCount(uint number)
    {
        int count = 0;
        while (number > 0)
        {
            count++;
            number /= 2;
        }
        return count;
    }
    //method to reverse the meaningful bits order
    public static uint ReverseBits(uint number)
    {
        uint result = 0;
        int power = BitCount(number) - 1;
        while (number > 0)
        {
            uint bit = number & 1;
            result += bit * (uint)Math.Pow(2, power);
            number = number >> 1;
            power--;
        }
        return result;
    }
}