using System;

class BitPaths
{
    static void Main()
    {
        //parse the input
        int n = int.Parse(Console.ReadLine());
        //set up an array for each of the 8 numbers
        int[] board = new int[8];

        for (int count = 0; count < n; count++)
        {
            //parse each command n times
            string pathInput = Console.ReadLine();
            //use a method to split the command into an array
            int[] path = ReturnPath(pathInput);
            //the mask for the first position change; 8 is 1000 in binary form
            //shift it right to get the start position 
            int mask = 8 >> path[0];
            //change the first number in the board with XOR
            board[0] ^= mask;
            //change the next 7 numbers
            for (int i = 1; i < 8; i++)
            {
                //shift the mask left or right
                //depending on the command
                if (path[i] == -1)
                {
                    mask = mask << 1;
                }
                if (path[i] == 1)
                {
                    mask = mask >> 1;
                }
                //the case when the command is 0 is not needed
                //the mask is unchanged
                //finally change the number with the right mask
                board[i] ^= mask;
            }
        }
        //calculate the sum of the numbers in the board
        int sum = 0;
        for (int i = 0; i < board.Length; i++)
        {
            sum += board[i];
        }
        //print the result in binary and hexadecimal!
        Console.WriteLine(Convert.ToString(sum, 2));
        Console.WriteLine("{0:X}", sum);
    }
    public static int[] ReturnPath(string input)
    {
        string[] pathString = input.Split(',');
        int[] path = new int[pathString.Length];
        for (int i = 0; i < path.Length; i++)
        {
            path[i] = int.Parse(pathString[i]);
        }
        return path;
    }
}