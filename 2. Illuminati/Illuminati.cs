using System;

class Illuminati
{
    static void Main()
    {
        //parse input
        string message = Console.ReadLine();
        //variables for the result
        int vowelCount = 0;
        int vowelSum = 0;
        //loop through all of the letters in the message
        for (int i = 0; i < message.Length; i++)
        {
            //if a vowel is found, the value is > 0
            if (ReturnVowelValue(message[i]) > 0)
            {
                //increase count and sum
                vowelCount++;
                vowelSum += ReturnVowelValue(message[i]);
            }
        }
        //display the result
        Console.WriteLine(vowelCount);
        Console.WriteLine(vowelSum);

    }
    //method for returning vowel values
    public static int ReturnVowelValue(char vowel)
    {
        int value = 0;
        switch (vowel)
        {
            case 'a':
            case 'A': value = 65;
                break;
            case 'e':
            case 'E': value = 69;
                break;
            case 'i':
            case 'I': value = 73;
                break;
            case 'o':
            case 'O': value = 79;
                break;
            case 'u':
            case 'U': value = 85;
                break;
        }
        return value;
    }
}