using System;

class FruitMarket
{
    static void Main()
    {
        //parse day of week
        string weekday = Console.ReadLine();

        //parse data for the three products
        decimal quantity1 = decimal.Parse(Console.ReadLine());
        string product1 = Console.ReadLine();

        decimal quantity2 = decimal.Parse(Console.ReadLine());
        string product2 = Console.ReadLine();

        decimal quantity3 = decimal.Parse(Console.ReadLine());
        string product3 = Console.ReadLine();

        //calculate the price of each item with the methods
        decimal price1 = quantity1 * ReturnPrice(product1) * DiscountMultiplier(weekday, product1);
        decimal price2 = quantity2 * ReturnPrice(product2) * DiscountMultiplier(weekday, product2);
        decimal price3 = quantity3 * ReturnPrice(product3) * DiscountMultiplier(weekday, product3);

        //sum the total price and print it on the console
        decimal totalPrice = price1 + price2 + price3;
        Console.WriteLine("{0:F2}", totalPrice);
    }
    public static decimal ReturnPrice(string input)
    {
        decimal price = 0;
        switch (input)
        {
            case "banana": price = 1.80M;
                break;
            case "cucumber": price = 2.75M;
                break;
            case "tomato": price = 3.20M;
                break;
            case "orange": price = 1.60M;
                break;
            case "apple": price = 0.86M;
                break;
        }
        return price;
    }
    public static decimal DiscountMultiplier(string weekday, string product)
    {
        decimal discount = 1;
        switch (weekday)
        {
            case "Friday": discount = 0.9M;
                break;
            case "Sunday": discount = 0.95M;
                break;
            case "Tuesday":
                if (product == "banana" || product == "orange" || product == "apple")
                {
                    discount = 0.8M;
                }
                break;
            case "Wednesday":
                if (product == "cucumber" || product == "tomato")
                {
                    discount = 0.9M;
                }
                break;
            case "Thursday":
                if (product == "banana")
                {
                    discount = 0.7M;
                }
                break;
        }
        return discount;
    }
}