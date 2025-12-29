using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Capgemini_Training
{
    /// <summary>
    /// Provides a console application for calculating and displaying profit or loss based on user-entered cost price
    /// and selling price values.
    /// </summary>
    /// <remarks>The application prompts the user to input the cost price and selling price, then determines
    /// whether a profit, loss, or neither has occurred. It displays the corresponding percentage to the console. This
    /// class is intended to be run as a standalone program and is not designed for use as a library
    /// component.</remarks>
    class Profit_Loss
    {
        static void Main(string[] args)
        {
            // Ask user to enter Cost Price
            Console.WriteLine("Enter Cost Price:");
            double costPrice = double.Parse(Console.ReadLine());

            // Ask user to enter Selling Price
            Console.WriteLine("Enter Selling Price:");
            double sellingPrice = double.Parse(Console.ReadLine());

            // Check if there is profit
            if (sellingPrice > costPrice)
            {
                // Calculate profit amount
                double profit = sellingPrice - costPrice;

                // Calculate profit percentage
                double profitPercent = (profit / costPrice) * 100;

                Console.WriteLine("Profit Occurred");
                Console.WriteLine("Profit Percentage: " + profitPercent + "%");
            }
            // Check if there is loss
            else if (sellingPrice < costPrice)
            {
                // Calculate loss amount
                double loss = costPrice - sellingPrice;

                // Calculate loss percentage
                double lossPercent = (loss / costPrice) * 100;

                Console.WriteLine("Loss Occurred");
                Console.WriteLine("Loss Percentage: " + lossPercent + "%");
            }
            // If cost price and selling price are equal
            else
            {
                Console.WriteLine("No Profit No Loss");
            }
        }
    }
}

