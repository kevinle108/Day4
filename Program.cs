using System;
using System.Collections.Generic;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {

            var itemCodes = new List<string> { "B1", "B2", "B3", "B4", "B5", "B6", "D1", "D2", "D3" };
            var itemNames = new List<string> { "Sausage Biscuit", "Sausage with Egg Biscuit", "Bacon, Egg & Cheese Biscuit", "Bacon, Egg & Cheese Bagel", "Hotcakes", "Hotcakes and Sausage", "Coffee", "Soft Drink", "Tea" };
            var itemPrices = new List<double> { 3.50, 4.00, 4.25, 4.50, 3.75, 4.75, 2.50, 1.50, 1.75 };
            //var itemPricesDeci = itemPrices.ConvertAll(x => Convert.ToDecimal(x));
            string itemCode;
            double total = 0.00;
            var itemsOrdered = new List<string>();
            do
            {
                Console.Write("Enter item code: ");
                itemCode = Console.ReadLine().ToUpper();
                
                if (itemCodes.Contains(itemCode))
                {
                    int itemQuantity;
                    bool validQuantity;
                    do
                    {
                        Console.Write($"Enter {itemCode} quantity: ");
                        string input = Console.ReadLine();
                        bool validInt = int.TryParse(input, out itemQuantity);
                        validQuantity = validInt && itemQuantity > 0;
                        if (!validQuantity) Console.WriteLine("Error! Not a valid quantity. Please try again.");
                    } while (!validQuantity);
                    int itemIndex = itemCodes.IndexOf(itemCode);
                    double itemTotal = itemPrices[itemIndex] * itemQuantity;
                    total += itemTotal;
                    string itemLine = $"{itemQuantity} {itemNames[itemIndex]}: ${itemPrices[itemIndex]} x {itemQuantity} = ${itemTotal}";
                    itemsOrdered.Add(itemLine);
                    Console.WriteLine(itemLine);
                    Console.WriteLine($"Current Total: ${total}");
                } 
                if (!itemCodes.Contains(itemCode) && itemCode != "")
                {
                    Console.WriteLine("Error! Item not on menu. Please try again.");
                }
            } while (itemCode != "");
            Console.WriteLine("\nORDER SUMMARY:");
            foreach (string item in itemsOrdered)
            {
                Console.WriteLine($"  {item}");
            }
            Console.WriteLine($"  Total + 6% Sales Tax: ${total} x 1.06 = ");
            total = Math.Round((total * 1.06), 2); // adds 6% sales tax rounded to 2 decimal places;
            Console.WriteLine($"FINAL TOTAL: ${total}");
            Console.Write($"Enter amount tendered: ");
            double amountTendered = Convert.ToDouble(Console.ReadLine());
            double change = Math.Round(amountTendered - total, 2);
            Console.WriteLine($"CHANGE: ${change}");


            Console.WriteLine("Done");



            //// checks the count of each list
            //Console.WriteLine($"{itemCodes.Count}, {itemNames.Count}, {itemPrices.Count}");

            //// Prints the menu 
            //for (int i = 0; i < itemCodes.Count - 1; i++)
            //{
            //    Console.WriteLine($"{itemCodes[i]} - {itemNames[i]} (${itemPrices[i]})");
            //}


        }
    }
}
