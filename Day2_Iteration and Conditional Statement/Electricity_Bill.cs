using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Training
{
    /// <summary>
    /// Represents a program for calculating an electricity bill based on the number of units consumed.
    /// </summary>
    /// <remarks>The calculation applies different rates depending on the consumption tier and includes an
    /// additional multiplier for high-value bills. This class is intended to be used as a console application entry
    /// point.</remarks>
    public class Electricity_Bill
    {
        /// <summary>
        /// Serves as the entry point for the application, prompting the user to enter the number of electricity units
        /// consumed and calculating the corresponding bill amount.
        /// </summary>
        /// <remarks>The method reads user input from the console to determine the number of units
        /// consumed and applies a tiered rate structure to calculate the final bill. If the calculated bill exceeds
        /// 400, an additional multiplier is applied. The result is displayed to the user via the console.</remarks>
        /// <param name="args">An array of command-line arguments. This parameter is not used in this application.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Units Consumed: ");
            double unitsConsumed = double.Parse(Console.ReadLine());
            double FinalBill = 0;
            /// Calculate bill based on units consumed
            if (unitsConsumed < 200)
            {
                FinalBill = unitsConsumed * 1.20;
            }
            else if(unitsConsumed>=200 && unitsConsumed < 400)
            {
                FinalBill = unitsConsumed * 1.50;
            }
            else if(unitsConsumed>=400 && unitsConsumed < 600)
            {
                FinalBill = unitsConsumed * 1.80;
            }
            else if (unitsConsumed >= 600)
            {
                FinalBill = unitsConsumed * 2.0;
            }
            if (FinalBill > 400)
            {
                FinalBill *= 11.5;
            }

            Console.WriteLine("Your Electricity Bill is: " + FinalBill);
        }
    }
}
