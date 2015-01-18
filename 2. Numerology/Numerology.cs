using System;

class Numerology
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] array = SplitInput(input);
        int day = int.Parse(array[0]);
        int month = int.Parse(array[1]);
        int year = int.Parse(array[2]);
        string name = array[3];

        long result = day * month * year;
        if (month % 2 != 0)
        {
            result *= result;
        }
        long nameValue = ReturnNameWeight(name);
        result += nameValue;
        while (result > 13)
        {
            result = NumberDigitsSum(result);
        }
        Console.WriteLine(result);
    }
    public static string[] SplitInput(string input)
    {
        string[] array = input.Split(' ', '.');
        return array;
    }
    public static int SymbolWeight(char symbol)
    {
        int weight = 0;
        switch (symbol)
        {
            case 'a': weight = 1;
                break;
            case 'b': weight = 2;
                break;
            case 'c': weight = 3;
                break;
            case 'd': weight = 4;
                break;
            case 'e': weight = 5;
                break;
            case 'f': weight = 6;
                break;
            case 'g': weight = 7;
                break;
            case 'h': weight = 8;
                break;
            case 'i': weight = 9;
                break;
            case 'j': weight = 10;
                break;
            case 'k': weight = 11;
                break;
            case 'l': weight = 12;
                break;
            case 'm': weight = 13;
                break;
            case 'n': weight = 14;
                break;
            case 'o': weight = 15;
                break;
            case 'p': weight = 16;
                break;
            case 'q': weight = 17;
                break;
            case 'r': weight = 18;
                break;
            case 's': weight = 19;
                break;
            case 't': weight = 20;
                break;
            case 'u': weight = 21;
                break;
            case 'v': weight = 22;
                break;
            case 'w': weight = 23;
                break;
            case 'x': weight = 24;
                break;
            case 'y': weight = 25;
                break;
            case 'z': weight = 26;
                break;
            case 'A': weight = 1 * 2;
                break;
            case 'B': weight = 2 * 2;
                break;
            case 'C': weight = 3 * 2;
                break;
            case 'D': weight = 4 * 2;
                break;
            case 'E': weight = 5 * 2;
                break;
            case 'F': weight = 6 * 2;
                break;
            case 'G': weight = 7 * 2;
                break;
            case 'H': weight = 8 * 2;
                break;
            case 'I': weight = 9 * 2;
                break;
            case 'J': weight = 10 * 2;
                break;
            case 'K': weight = 11 * 2;
                break;
            case 'L': weight = 12 * 2;
                break;
            case 'M': weight = 13 * 2;
                break;
            case 'N': weight = 14 * 2;
                break;
            case 'O': weight = 15 * 2;
                break;
            case 'P': weight = 16 * 2;
                break;
            case 'Q': weight = 17 * 2;
                break;
            case 'R': weight = 18 * 2;
                break;
            case 'S': weight = 19 * 2;
                break;
            case 'T': weight = 20 * 2;
                break;
            case 'U': weight = 21 * 2;
                break;
            case 'V': weight = 22 * 2;
                break;
            case 'W': weight = 23 * 2;
                break;
            case 'X': weight = 24 * 2;
                break;
            case 'Y': weight = 25 * 2;
                break;
            case 'Z': weight = 26 * 2;
                break;
            case '0': weight = 0;
                break;
            case '1': weight = 1;
                break;
            case '2': weight = 2;
                break;
            case '3': weight = 3;
                break;
            case '4': weight = 4;
                break;
            case '5': weight = 5;
                break;
            case '6': weight = 6;
                break;
            case '7': weight = 7;
                break;
            case '8': weight = 8;
                break;
            case '9': weight = 9;
                break;
        }
        return weight;
    }
    public static int ReturnNameWeight(string name)
    {
        int weight = 0;
        for (int i = 0; i < name.Length; i++)
        {
            weight += SymbolWeight(name[i]);
        }
        return weight;
    }
    public static long NumberDigitsSum(long number)
    {
        long sum = 0;
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }
}