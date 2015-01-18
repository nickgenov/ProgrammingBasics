using System;
using System.Text;

class SpyHard
{
    static void Main()
    {
        int key = int.Parse(Console.ReadLine());
        string message = Console.ReadLine();

        //numeral system used
        int numeralSystem = key;
        //the number of symbols in the secret message
        int messageSymbols = message.Length;
        //the value of the message in the decimal number system
        int messageValue = ReturnMessageValue(message);

        //convert the message value to a numbering system with base "key"
        int num = messageValue;
        StringBuilder convertReverse = new StringBuilder();
        while (num > 0)
        {
            int digit = num % key;
            num /= key;
            convertReverse.Append(digit);
        }
        string resultReverse = convertReverse.ToString();
        //reverse the string to get the correct result
        StringBuilder convert = new StringBuilder();
        for (int i = resultReverse.Length - 1; i >= 0; i--)
        {
            string digit = Convert.ToString(resultReverse[i]);
            convert.Append(digit);
        }
        string result = convert.ToString();

        //concatenate the final result to print on the console
        string output = "" + numeralSystem + messageSymbols + result;
        //print it on the console
        Console.WriteLine(output);
    }
    public static int ReturnSymbolValue(char symbol)
    {
        int value = 0;
        if (symbol >= 65 && symbol <= 90)
        {
            value = symbol - 64;
        }
        else if (symbol >= 97 && symbol <= 122)
        {
            value = symbol - 96;
        }
        else
        {
            value = symbol;
        }
        return value;
    }
    public static int ReturnMessageValue(string message)
    {
        int messageValue = 0;
        for (int i = 0; i < message.Length; i++)
        {
            int symbolValue = ReturnSymbolValue(message[i]);
            messageValue += symbolValue;
        }
        return messageValue;
    }
}