using System;

class ChangeEvenBits
{
    static void Main()
    {
        int numCount = int.Parse(Console.ReadLine());
        int[] nums = new int[numCount];

        for (int index = 0; index < nums.Length; index++)
        {
            nums[index] = int.Parse(Console.ReadLine());
        }
        ulong numberToChange = ulong.Parse(Console.ReadLine());

        int bitsChanged = 0;

        for (int index = 0; index < numCount; index++)
        {
            int bitCountToChange = BinaryLength(nums[index]);
            int pos = 0;
            for (int count = 0; count < bitCountToChange; count++)
            {
                int bitAtPosition = CheckBitAtPosition(numberToChange, pos);
                if (bitAtPosition == 0)
                {
                    numberToChange |= (ulong)1 << pos;
                    bitsChanged++;
                }
                pos += 2;
            }
        }
        Console.WriteLine(numberToChange);
        Console.WriteLine(bitsChanged);
    }
    public static int BinaryLength(int number)
    {
        int length = 0;
        if (number == 0)
        {
            length = 1;
        }
        else
        {
            while (number > 0)
            {
                number /= 2;
                length++;
            }
        }
        return length;
    }
    public static int CheckBitAtPosition(ulong number, int position)
    {
        int bit = (int)((number >> position) & 1);
        return bit;
    }
}