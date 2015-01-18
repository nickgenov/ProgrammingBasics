using System;

class Disk
{
    static void Main()
    {
        //parse input
        int fieldSize = int.Parse(Console.ReadLine());
        int radius = int.Parse(Console.ReadLine());

        //find out which the row and col
        //of the circle center
        int centerCol = (fieldSize / 2) + 1;
        int centerRow = (fieldSize / 2) + 1;

        //loop through the field from 1 to fieldSize
        for (int row = 1; row <= fieldSize; row++)
        {
            for (int col = 1; col <= fieldSize; col++)
            {
                //calculate the distance from the center
                int deltaX = Math.Abs(centerCol - col);
                int deltaY = Math.Abs(centerRow - row);
                
                //use the pythagorean's theorem to calculate the radius
                //of the circle the current point in the field is in
                double distanceFromCenter = Math.Sqrt((deltaX * deltaX + deltaY * deltaY));

                //print the correct symbol
                if (distanceFromCenter > radius)
                {
                    //the point is outside of the circle
                    Console.Write('.');
                }
                else
                {
                    //the point is inside
                    Console.Write('*');
                }
            }
            //start a new row
            Console.WriteLine();
        }
    }
}