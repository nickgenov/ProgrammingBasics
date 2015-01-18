using System;

class BitLock
{
    static void Main()
    {
        //parse the input string, containing the 8 numbers
        string stringNumbers = Console.ReadLine();
        //put them in an array, representing the lock
        int[] numbers = SplitString(stringNumbers);

        while (true)
        {
            //parse the command
            string input = Console.ReadLine();
            if (input == "end")
            {
                //leave the infinite loop 
                break;
            }
            else
            {
                string[] commandsArray = input.Split(' ');
                //if the commands are 2, we have to check[col]
                if (commandsArray.Length == 2)
                {
                    //the number of bits = 1 @ col
                    int oneBitCount = 0;
                    //the column to check
                    int pos = int.Parse(commandsArray[1]);
                    //check all numbers in the table
                    foreach (var num in numbers)
                    {
                        int bit = (num >> pos) & 1;
                        if (bit == 1)
                        {
                            oneBitCount++;
                        }
                    }
                    //print the result on the console
                    Console.WriteLine(oneBitCount);
                }
                //if the commands are 3, we have to roll left or right
                else if (commandsArray.Length == 3)
                {
                    //get the commands from the string array
                    int row = int.Parse(commandsArray[0]);
                    string direction = commandsArray[1];
                    int rotations = int.Parse(commandsArray[2]);

                    //roll left
                    if (direction == "left")
                    {
                        int num = numbers[row];
                        //Console.WriteLine("number: " + Convert.ToString(num, 2).PadLeft(12, '0'));
                        for (int count = 0; count < rotations; count++)
                        {
                            //get the bit at column 11
                            int bit = (num >> 11) & 1;

                            //mask for removing shiftet bits left beyond pos 11 
                            //important to get a correct result!
                            int mask = (int)(Math.Pow(2, 20) - 1);
                            mask <<= 12;
                            mask = ~mask;

                            //move the bits one position left
                            num <<= 1;
                            //AND the number and mask to remove bits beyond column 11
                            num &= mask;

                            //add the bit at column 11 to column 0
                            num |= bit;
                            //Console.WriteLine("left:   " + Convert.ToString(num, 2).PadLeft(12, '0'));
                        }
                        //put the rotated number back in the array
                        numbers[row] = num;
                    }
                    else if (direction == "right")
                    {
                        int num = numbers[row];
                        //Console.WriteLine("number: " + Convert.ToString(num, 2).PadLeft(12, '0'));
                        for (int count = 0; count < rotations; count++)
                        {
                            //get the bit at column 0
                            int bit = num & 1;
                            //move the bits one position right
                            num >>= 1;
                            //add the bit at column 0 to column 11
                            num |= (bit << 11);
                            //Console.WriteLine("right:  " + Convert.ToString(num, 2).PadLeft(12, '0'));
                        }
                        //put the rotated number back in the array
                        numbers[row] = num;
                    }
                }
            }
        }
        //print the numbers on a single line, separated by a single space
        for (int index = 0; index < numbers.Length; index++)
        {
            if (index == (numbers.Length - 1))
            {
                //do not print a space after the last number
                Console.WriteLine(numbers[index]);
            }
            else
            {
                Console.Write("{0} ", numbers[index]);
            }
        }
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
}

