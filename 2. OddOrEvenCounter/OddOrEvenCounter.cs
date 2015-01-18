using System;

class OddOrEvenCounter
{
    static void Main()
    {
        int numberOfSets = int.Parse(Console.ReadLine());
        int numbersInEachSet = int.Parse(Console.ReadLine());
        string numbersToCount = Console.ReadLine();

        int typeCount = 0;
        int typeCountMax = int.MinValue;
        int setCount = 1;
        int setCountMax = 0;

        if (numbersToCount == "odd")
        {
            while (numberOfSets > 0)
            {
                for (int count = 0; count < numbersInEachSet; count++)
                {
                    int number = int.Parse(Console.ReadLine());
                    if (number % 2 != 0)
                    {
                        typeCount++;
                    }
                    if (typeCount > typeCountMax)
                    {
                        typeCountMax = typeCount;
                        setCountMax = setCount;
                    }
                }
                typeCount = 0;
                setCount++;
                numberOfSets--;
            }
            if (typeCountMax > 0)
            {
                string ordinal = ConvertNumberToOrdinal(setCountMax);
                Console.WriteLine("{0} set has the most {1} numbers: {2}", ordinal, numbersToCount, typeCountMax);
            }
            else
            {
                Console.WriteLine("No");
            }
        }
        if (numbersToCount == "even")
        {
            while (numberOfSets > 0)
            {
                for (int count = 0; count < numbersInEachSet; count++)
                {
                    int number = int.Parse(Console.ReadLine());
                    if (number % 2 == 0)
                    {
                        typeCount++;
                    }
                    if (typeCount > typeCountMax)
                    {
                        typeCountMax = typeCount;
                        setCountMax = setCount;
                    }
                }
                typeCount = 0;
                setCount++;
                numberOfSets--;
            }
            if (typeCountMax > 0)
            {
                string ordinal = ConvertNumberToOrdinal(setCountMax);
                Console.WriteLine("{0} set has the most {1} numbers: {2}", ordinal, numbersToCount, typeCountMax);
            }
            else
            {
                Console.WriteLine("No");
            }
        }

    }
    public static string ConvertNumberToOrdinal(int number)
    {
        string ordinal = "";
        switch (number)
        {
            case 1: ordinal = "First";
                break;
            case 2: ordinal = "Second";
                break;
            case 3: ordinal = "Third";
                break;
            case 4: ordinal = "Fourth";
                break;
            case 5: ordinal = "Fifth";
                break;
            case 6: ordinal = "Sixth";
                break;
            case 7: ordinal = "Seventh";
                break;
            case 8: ordinal = "Eighth";
                break;
            case 9: ordinal = "Ninth";
                break;
            case 10: ordinal = "Tenth";
                break;
            default: ordinal = "Invalid number of sets";
                break;
        }
        return ordinal;
    }
}

