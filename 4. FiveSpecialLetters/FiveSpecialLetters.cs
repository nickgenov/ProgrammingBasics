using System;

class FiveSpecialLetters
{
    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());

        bool validSolution = false;

        for (int a = 97; a <= 101; a++)
        {
            for (int b = 97; b <= 101; b++)
            {
                for (int c = 97; c <= 101; c++)
                {
                    for (int d = 97; d <= 101; d++)
                    {
                        for (int e = 97; e <= 101; e++)
                        {
                            string sequence = "" + (char)a + (char)b + (char)c + (char)d + (char)e;
                            int weight = CalcStringWeight(RemoveDuplicateLetters(sequence));
                            if (weight >= start && weight <= end)
                            {
                                validSolution = true;
                                Console.Write("{0} ", sequence);
                            }
                        }
                    }
                }
            }
        }
        if (!validSolution)
        {
            Console.WriteLine("No");
        }
        Console.WriteLine();
    }
    public static int CalcLetterWeight(char letter)
    {
        int letterWeight = 0;
        switch (letter)
        {
            case 'a': letterWeight = 5;
                break;
            case 'b': letterWeight = -12;
                break;
            case 'c': letterWeight = 47;
                break;
            case 'd': letterWeight = 7;
                break;
            case 'e': letterWeight = -32;
                break;
        }
        return letterWeight;
    }
    public static string RemoveDuplicateLetters(string input)
    {
        char[] array = new char[input.Length];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = input[i];
        }
        int start = array.Length - 1;

        while (start > 0)
        {
            for (int i = start; i > 0; i--)
            {
                if (array[start] == array[i - 1])
                {
                    array[start] = '*';
                }
            }
            start--;
        }
        string result = string.Empty;
        foreach (var character in array)
        {
            if (character != '*')
            {
                result += character;
            }
        }
        return result;
    }
    public static int CalcStringWeight(string input)
    {
        int weight = 0;
        int multiplier = 1;
        for (int i = 0; i < input.Length; i++)
        {
            weight += multiplier * CalcLetterWeight(input[i]);
            multiplier++;
        }
        return weight;
    }
}