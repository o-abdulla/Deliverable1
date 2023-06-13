// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main()
    {
        // Item stock and restock values
        int sodaStock = 100;
        int sodaRestock = 40;

        int chipsStock = 40;
        int chipsRestock = 20;

        int candyStock = 60;
        int candyRestock = 40;

        // Checking stock for Soda
        Console.Write("Welcome to the restocking tool.\n\n");
        Console.Write("How many sodas have been sold today? ");
        int sodasSold = int.Parse(Console.ReadLine());
        if (sodasSold > sodaStock)
        {
            Console.WriteLine("\nValue too high. Stock not adjusted");
        }
        else
        {
            sodaStock -= sodasSold;
            Console.WriteLine("\nRemaining Soda stock: " + sodaStock);
            if (sodaStock <= sodaRestock)
            {
                Console.WriteLine("\nSoda needs to be restocked");
            }
        }

        // Checking stock for Chips
        Console.Write("\nHow many chips have been sold today? ");
        int chipsSold = int.Parse(Console.ReadLine());
        if (chipsSold > chipsStock)
        {
            Console.WriteLine("\nValue too high. Stock not adjusted");
        }
        else
        {
            chipsStock -= chipsSold;
            Console.WriteLine("\nRemaining Chips stock: " + chipsStock);
            if (chipsStock <= chipsRestock)
            {
                Console.WriteLine("\nChips needs to be restocked");
            }
        }

        // Checking stock for Candy
        Console.Write("\nHow many candies have been sold today? ");
        int candySold = int.Parse(Console.ReadLine());
        if (candySold > candyStock)
        {
            Console.WriteLine("\nValue too high. Stock not adjusted");
        }
        else
        {
            candyStock -= candySold;
            Console.WriteLine("\nRemaining Candy stock: " + candyStock);
            if (candyStock <= candyRestock)
            {
                Console.WriteLine("\nCandy needs to be restocked");
            }
        }
    }
}
