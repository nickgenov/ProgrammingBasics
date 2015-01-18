using System;

class PaintBall
{
    static void Main()
    {
        //initial canvas
        int[] canvas = new int[10];
        for (int i = 0; i < canvas.Length; i++)
        {
            canvas[i] = 1023;
        }
        //black paint if -1, white paint if 1
        int shotKind = -1;
        //read the commands
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "End")
            {
                break;
            }
            else
            {
                int[] command = SplitString(input);
                int row = command[0];
                int col = command[1];
                int radius = command[2];
                //check if the shot is black or white
                if (shotKind == -1)
                {
                    //black paint
                    for (int canvasRow = 0; canvasRow < canvas.Length; canvasRow++)
                    {
                        if ((canvasRow >= row - radius) && (canvasRow <= row + radius))
                        {
                            for (int pos = 0; pos <= 9; pos++)
                            {
                                if (pos >= col - radius && pos <= col + radius)
                                {
                                    int mask = ~(1 << pos);
                                    canvas[canvasRow] &= mask;
                                }
                            }
                        }
                    }
                }
                else if (shotKind == 1)
                {
                    //white paint
                    for (int canvasRow = 0; canvasRow < canvas.Length; canvasRow++)
                    {
                        if ((canvasRow >= row - radius) && (canvasRow <= row + radius))
                        {
                            for (int pos = 0; pos <= 9; pos++)
                            {
                                if (pos >= col - radius && pos <= col + radius)
                                {
                                    int mask = 1 << pos;
                                    canvas[canvasRow] |= mask;
                                }
                            }
                        }
                    }
                }
            }
            shotKind *= -1;
        }
        //sum the decimal values of the numbers in the canvas
        int sum = 0;
        foreach (var num in canvas)
        {
            sum += num;
        }
        //print the result on the console
        Console.WriteLine(sum);
    }
    public static int[] SplitString(string input)
    {
        string[] array = input.Split(' ');
        int[] numbers = new int[array.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Convert.ToString(array[i]));
        }
        return numbers;
    }
}