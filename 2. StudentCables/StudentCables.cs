using System;

class StudentCables
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int totalCableLength = 0;
        int usefulCablesCount = 0;

        for (int i = 0; i < n; i++)
        {
            int cableLength = int.Parse(Console.ReadLine());
            string measure = Console.ReadLine();
            if (measure == "meters")
            {
                cableLength *= 100;
            }
            if (cableLength >= 20)
            {
                totalCableLength += cableLength;
                usefulCablesCount++;
            }
        }

        int cableLost = (usefulCablesCount - 1) * 3;
        int usefulCableLength = totalCableLength - cableLost;

        int studentCablesCount = usefulCableLength / 504;
        int cableLeft = usefulCableLength % 504;

        Console.WriteLine(studentCablesCount);
        Console.WriteLine(cableLeft);
    }
}