using System;

class BiggestTriple
{
    static void Main()
    {
        string input = Console.ReadLine();
        int[] numbers = SplitStringToIntegers(input);

        if (numbers.Length <= 3)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("{0} ", numbers[i]);
            }
            Console.WriteLine();
            return;
        }

        int big1 = 0;
        int big2 = 0;
        int big3 = 0;
        int sumBiggest = int.MinValue;

        for (int i = 0; i < numbers.Length - 2; i += 3)
        {
            int sum = numbers[i] + numbers[i + 1] + numbers[i + 2];
            if (sumBiggest < sum)
            {
                sumBiggest = sum;
                big1 = numbers[i];
                big2 = numbers[i + 1];
                big3 = numbers[i + 2];
            }
        }

        if (numbers.Length % 3 == 0)
        {
            Console.WriteLine("{0} {1} {2}", big1, big2, big3);
        }
        else
        {
            int lengthLast = numbers.Length % 3;
            int sumLast = 0;
            for (int i = numbers.Length - lengthLast; i < numbers.Length; i++)
            {
                sumLast += numbers[i];
            }
            if (sumLast > sumBiggest)
            {
                for (int i = numbers.Length - lengthLast; i < numbers.Length; i++)
                {
                    Console.Write("{0} ", numbers[i]);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", big1, big2, big3);
            }
        }
    }
    public static int[] SplitStringToIntegers(string input)
    {
        string[] stringNumbers = input.Split();
        int[] numbers = new int[stringNumbers.Length];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(stringNumbers[i]);
        }
        return numbers;
    }
}

