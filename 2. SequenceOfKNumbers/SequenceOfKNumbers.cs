using System;
 
class SequenceOfKNumbers
{
    static void Main()
    {
        //parse input
        string input = Console.ReadLine();
        int k = int.Parse(Console.ReadLine());
 
        //store the sequence of numbers in an array
        int[] numbers = SplitStringToInt(input);
 
        //in this case we have to remove all numbers
        if (k == 1 && numbers.Length == 1)
        {
            Console.WriteLine();
            return;
        }
 
        //check the sequence from start to end
        int maxI = numbers.Length - k + 1;
        for (int i = 0; i < maxI; i++)
        {
            //check if the group of k elements is equal
            bool equal = true;
            int maxJ = i + k - 1;
            for (int j = i; j < maxJ; j++)
            {
                if (numbers[j] != numbers[j + 1])
                {
                    equal = false;
                }
            }
            //if it is equal, set them all to -2000
            //we will print only numbers > -2000 at the end
            if (equal)
            {
                for (int j = i; j < i + k; j++)
                {
                    numbers[j] = -2000;
               }
            }
        }
        //print the result
        foreach (var num in numbers)
        {
            if (num > - 2000)
            {
                Console.Write("{0} ", num);
            }
        }
        Console.WriteLine();
    }
    public static int[] SplitStringToInt(string input)
    {
        string[] stringArray = input.Split(' ');
        int[] numbers = new int[stringArray.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(stringArray[i]);
        }
        return numbers;
    }
} 