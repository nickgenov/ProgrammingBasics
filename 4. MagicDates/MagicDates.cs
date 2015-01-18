using System;

class MagicDates
{
    static void Main()
    {
        //parse input
        int startYear = int.Parse(Console.ReadLine());
        int endYear = int.Parse(Console.ReadLine());
        int magicWeight = int.Parse(Console.ReadLine());
        //set new DateTime variables for start and end moment
        DateTime start = new DateTime(startYear, 1, 1);
        DateTime end = new DateTime(endYear, 12, 31);
        //use this to check if there is a solution
        bool validSolution = false;
        //loop through all the days from start to end
        for (DateTime date = start; date <= end; date = date.AddDays(1))
        {
            //convert the date to a string in the needed format
            string dateString = string.Format("{0:ddMMyyyy}", date);
            //calculate the date weight with a method
            int weight = CalculateDateWeight(dateString);
            //if the weight is magic, print result
            if (weight == magicWeight)
            {
                //found a solution
                validSolution = true;
                Console.WriteLine("{0:dd-MM-yyyy}", date);
            }
        }
        //if no solution was found
        if (validSolution == false)
        {
            Console.WriteLine("No");
        }
    }
    //method for calculating date weight
    public static int CalculateDateWeight(string date)
    {
        //new array of integers
        int[] array = new int[date.Length];
        //fill it with the numbers in the date string
        for (int i = 0; i < array.Length; i++)
        {
            //parse the char, converted to string
            array[i] = int.Parse(Convert.ToString(date[i]));
        }
        //variables for the weight calculation
        int weight = 0;
        int start = 0;
        //loop through the array
        while (start <= array.Length - 2)
        {
            //from different start point each time
            for (int i = start; i < array.Length - 1; i++)
            {
                weight += array[start] * array[i + 1];
            }
            //increase start position by 1
            start++;
        }
        //return calculated weight
        return weight;
    }
}