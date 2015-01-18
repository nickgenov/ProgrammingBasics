using System;

class BookOrders
{
    static void Main()
    {
        //parse the number of orders
        int numberOfOrders = int.Parse(Console.ReadLine());
        //variables for the calculations
        int totalBooks = 0;
        double priceAllBooks = 0;
        int totalPackets = 0;
        //loop "count = number of orders" times
        for (int count = 0; count < numberOfOrders; count++)
        {
            //parse input
            int numberOfPackets = int.Parse(Console.ReadLine());
            int booksPerPacket = int.Parse(Console.ReadLine());
            double bookPrice = double.Parse(Console.ReadLine());
            //count the packets and books
            totalPackets += numberOfPackets;
            totalBooks += numberOfPackets * booksPerPacket;
            //if-else for all cases
            if (numberOfPackets < 10)
            {
                priceAllBooks += (booksPerPacket * numberOfPackets) * bookPrice;
            }
            else if (numberOfPackets >= 10 && numberOfPackets <= 19)
            {
                priceAllBooks += 0.95 * ((booksPerPacket * numberOfPackets) * bookPrice);
            }
            else if (numberOfPackets >= 20 && numberOfPackets <= 29)
            {
                priceAllBooks += 0.94 * ((booksPerPacket * numberOfPackets) * bookPrice);
            }
            else if (numberOfPackets >= 30 && numberOfPackets <= 39)
            {
                priceAllBooks += 0.93 * ((booksPerPacket * numberOfPackets) * bookPrice);
            }
            else if (numberOfPackets >= 40 && numberOfPackets <= 49)
            {
                priceAllBooks += 0.92 * ((booksPerPacket * numberOfPackets) * bookPrice);
            }
            else if (numberOfPackets >= 50 && numberOfPackets <= 59)
            {
                priceAllBooks += 0.91 * ((booksPerPacket * numberOfPackets) * bookPrice);
            }
            else if (numberOfPackets >= 60 && numberOfPackets <= 69)
            {
                priceAllBooks += 0.90 * ((booksPerPacket * numberOfPackets) * bookPrice);
            }
            else if (numberOfPackets >= 70 && numberOfPackets <= 79)
            {
                priceAllBooks += 0.89 * ((booksPerPacket * numberOfPackets) * bookPrice);
            }
            else if (numberOfPackets >= 80 && numberOfPackets <= 89)
            {
                priceAllBooks += 0.88 * ((booksPerPacket * numberOfPackets) * bookPrice);
            }
            else if (numberOfPackets >= 90 && numberOfPackets <= 99)
            {
                priceAllBooks += 0.87 * ((booksPerPacket * numberOfPackets) * bookPrice);
            }
            else if (numberOfPackets >= 100 && numberOfPackets <= 109)
            {
                priceAllBooks += 0.86 * ((booksPerPacket * numberOfPackets) * bookPrice);
            }
            else if (numberOfPackets >= 110)
            {
                priceAllBooks += 0.85 * ((booksPerPacket * numberOfPackets) * bookPrice);
            }
        }
        Console.WriteLine("{0}", totalBooks);
        Console.WriteLine("{0:F2}", priceAllBooks);
    }
}