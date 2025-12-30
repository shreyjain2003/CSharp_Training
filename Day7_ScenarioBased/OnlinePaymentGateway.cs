using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Training.Day7_ScenarioBased
{
        // 🔹 Base Class
        abstract class Payment
        {
            public abstract void ProcessPayment(decimal amount);
        }

        // 🔹 Credit Card Payment
        class CreditCardPayment : Payment
        {
            public override void ProcessPayment(decimal amount)
            {
                Console.WriteLine($"Processing Credit Card payment of ₹{amount}");
            }
        }

        // 🔹 UPI Payment
        class UPIPayment : Payment
        {
            public override void ProcessPayment(decimal amount)
            {
                Console.WriteLine($"Processing UPI payment of ₹{amount}");
            }
        }

        // 🔹 Net Banking Payment
        class NetBankingPayment : Payment
        {
            public override void ProcessPayment(decimal amount)
            {
                Console.WriteLine($"Processing Net Banking payment of ₹{amount}");
            }
        }

        // 🔹 Program Class
        class Program
        {
            static void Main()
            {
                Payment payment;

                payment = new CreditCardPayment();
                payment.ProcessPayment(2500);

                payment = new UPIPayment();
                payment.ProcessPayment(1200);

                payment = new NetBankingPayment();
                payment.ProcessPayment(5000);
            }
        }
}