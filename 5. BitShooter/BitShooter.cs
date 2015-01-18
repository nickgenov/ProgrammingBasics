using System;

class BitShooter
{
    static void Main()
    {
        //parse bit field integer
        ulong bitField = ulong.Parse(Console.ReadLine());

        //read the three commands
        for (int i = 0; i < 3; i++)
        {
            string input = Console.ReadLine();
            int[] shot = SplitString(input);
            int shotCenter = shot[0];
            int shotSize = shot[1];
            //key part of the solution is the shot mask!
            ulong mask = (ulong)Math.Pow(2, shotSize) - 1;
            //shift right
            if (shotCenter < shotSize / 2)
            {
                mask = ~(mask >> ((shotSize / 2) - shotCenter));
            }
            //shift left
            else 
            {
                mask = ~(mask << (shotCenter - (shotSize / 2)));
            }
            //shoot the bits with the mask
            bitField &= mask;
        }
        //split the bit field in two parts
        ulong BitFieldLeft = bitField >> 32;
        ulong BitFieldRight = (bitField << 32) >> 32;
        //display result
        Console.WriteLine("left: {0}", CountOneBits(BitFieldLeft));
        Console.WriteLine("right: {0}", CountOneBits(BitFieldRight));
    }
    public static int[] SplitString(string input)
    {
        string[] array = input.Split(' ');
        int[] numbers = new int[array.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(array[i]);
        }
        return numbers;
    }
    public static int CountOneBits(ulong number)
    {
        int count = 0;
        while (number > 0)
        {
            if (number % 2 == 1)
            {
                count++;
            }
            number /= 2;
        }
        return count;
    }
}