using System;

class NaBabaMiSmetalnika
{
    //NOT COMPLETELY SOLVED
    //cases when the position is -50...50 (outside of the smetalnik are wrong)

    //Telerik Academy Exam 1 @ 5 December 2013 Evening
    //Problem 5 – Na Baba mi Smetalnika
    static void Main()
    {
        int width = int.Parse(Console.ReadLine());
        long[] numbers = new long[8];
        for (long i = 0; i < numbers.Length; i++)
        {
            numbers[i] = long.Parse(Console.ReadLine());
        }

        long result = 0;

        while (true)
        {
            string command = Console.ReadLine();
            if (command == "stop")
            {
                break;
            }
            if (command == "reset")
            {
                for (long i = 0; i < numbers.Length; i++)
                {
                    int bitCount = CountOneBits(numbers[i]);
                    long num = (long)(Math.Pow(2, bitCount) - 1);
                    int shift = width - bitCount;
                    numbers[i] = num << shift;
                }
            }
            else if (command == "right")
            {
                int line = int.Parse(Console.ReadLine());
                int position = int.Parse(Console.ReadLine());

                long num = numbers[line];

                if (position < width)
                {
                    int pos = 0;
                    if (position < 0)
                    {
                        pos = width - 1;
                    }
                    else if (position < width)
                    {
                        pos = width - position - 1;
                    }
                    long mask = (long)(Math.Pow(2, pos + 1) - 1);
                    //count the 1 bits after (and including) position
                    int bitsCount = CountOneBits(num & mask);
                    //make a number with this many bits all shifted right
                    long rightBits = (long)(Math.Pow(2, bitsCount) - 1);
                    //clear the bits after (and including) position
                    num &= ~mask;
                    //put the right shifted bits in
                    num |= rightBits;
                    //put the resulting number back in the array
                    numbers[line] = num;
                }
            }
            else if (command == "left")
            {
                int line = int.Parse(Console.ReadLine());
                int position = int.Parse(Console.ReadLine());

                long num = numbers[line];

                if (position >= 0)
                {
                    int pos = 0;
                    if (position > width)
                    {
                        pos = width - 1;
                    }
                    else if (position < width)
                    {
                        pos = width - position - 1;
                    }
                    long mask = (long)(Math.Pow(2, width - pos) - 1);
                    mask <<= pos;
                    //count the 1 bits after (and including) position
                    int bitsCount = CountOneBits(num & mask);
                    //make a number with this many bits all shifted left
                    long leftBits = (long)(Math.Pow(2, bitsCount) - 1);
                    leftBits <<= width - bitsCount;
                    //clear the bits before (and including) position
                    num &= ~mask;
                    //put the left shifted bits in
                    num |= leftBits;
                    //put the resulting number back in the array
                    numbers[line] = num;
                }
            }
        }
        //calculate the number of columns with no bits
        long numNoBits = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            numNoBits |= numbers[i];
        }
        //count the number of 1 bits in the result
        int oneBits = CountOneBits(numNoBits);
        //count of the columns with no bits
        int countNoBitsColumns = width - oneBits;

        //sum all the numbers in the array
        long sum = 0;
        foreach (var num in numbers)
        {
            sum += num;
        }
        //calculate the final result
        result = sum * countNoBitsColumns;
        Console.WriteLine(result);
    }
    public static int CountOneBits(long number)
    {
        int count = 0;
        while (number > 0)
        {
            long bit = number & 1;
            if (bit == 1)
            {
                count++;
            }
            number >>= 1;
        }
        return count;
    }
}