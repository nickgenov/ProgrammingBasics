using System;

class LettersSymbolsNumbers
{
    static void Main()
    {
        //parse the count of strings
        int n = int.Parse(Console.ReadLine());
        //set up variables for storing the sums for each string
        int sumLetters = 0;
        int sumNumbers = 0;
        int sumSymbols = 0;
        //loop to read n strings
        for (int count = 0; count < n; count++)
        {
            string input = Console.ReadLine();
            //use the methods to calculate the result
            sumLetters += ReturnStringLettersValue(input);
            sumNumbers += ReturnStringNumbersValue(input);
            sumSymbols += ReturnStringSymbolsValue(input);
        }
        //print the result!
        Console.WriteLine(sumLetters);
        Console.WriteLine(sumNumbers);
        Console.WriteLine(sumSymbols);
    }
    //methods for the sum of all letters
    public static int ReturnLetterValue(char character)
    {
        int characterValue = 0;
        //all capital letters
        if (character >= 65 && character <= 90)
        {
            //for A(code 65) the multiplier is 1, for B - 2 and so on
            int multiplier = character - 64;
            characterValue = multiplier * 10;
        }
        //all small letters
        else if (character >= 97 && character <= 122)
        {
            //same idea as above
            int multiplier = character - 96;
            characterValue = multiplier * 10;
        }
        return characterValue;
    }
    public static int ReturnStringLettersValue(string input)
    {
        int sumLetters = 0;
        for (int index = 0; index < input.Length; index++)
        {
            sumLetters += ReturnLetterValue(input[index]);
        }
        return sumLetters;
    }
    //methods for the sum of all numbers
    public static int ReturnNumberValue(char character)
    {
        int characterValue = 0;
        //all digits
        switch (character)
        {
            case '0': characterValue = 0 * 20;
                break;
            case '1': characterValue = 1 * 20;
                break;
            case '2': characterValue = 2 * 20;
                break;
            case '3': characterValue = 3 * 20;
                break;
            case '4': characterValue = 4 * 20;
                break;
            case '5': characterValue = 5 * 20;
                break;
            case '6': characterValue = 6 * 20;
                break;
            case '7': characterValue = 7 * 20;
                break;
            case '8': characterValue = 8 * 20;
                break;
            case '9': characterValue = 9 * 20;
                break;
        }
        return characterValue;
    }
    public static int ReturnStringNumbersValue(string input)
    {
        int sumNumbers = 0;
        for (int index = 0; index < input.Length; index++)
        {
            sumNumbers += ReturnNumberValue(input[index]);
        }
        return sumNumbers;
    }
    //methods for the sum of all symbols
    public static int ReturSymbolValue(char character)
    {
        int characterValue = 0;
        //all of the symbols have these ASCII codes
        if ((character >= 33 && character <= 47) || (character >= 58 && character <= 64)
            || (character >= 91 && character <= 96) || (character >= 123 && character <= 126))
        {
            characterValue = 200;
        }
        return characterValue;
    }
    public static int ReturnStringSymbolsValue(string input)
    {
        int sumSymbols = 0;
        for (int index = 0; index < input.Length; index++)
        {
            sumSymbols += ReturSymbolValue(input[index]);
        }
        return sumSymbols;
    }
}