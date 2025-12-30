using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Training.Day7_ScenarioBased
{
        class BankAccount
        {
            // 🔒 Private data (cannot be accessed directly)
            private decimal balance;

            // Constructor
            public BankAccount(decimal initialBalance)
            {
                if (initialBalance >= 0)
                    balance = initialBalance;
                else
                    balance = 0;
            }

            // 💰 Deposit method
            public void Deposit(decimal amount)
            {
                if (amount > 0)
                {
                    balance += amount;
                    Console.WriteLine($"Deposited: {amount}");
                }
                else
                {
                    Console.WriteLine("Deposit amount must be positive.");
                }
            }

            // 💸 Withdraw method
            public void Withdraw(decimal amount)
            {
                if (amount > 0 && amount <= balance)
                {
                    balance -= amount;
                    Console.WriteLine($"Withdrawn: {amount}");
                }
                else
                {
                    Console.WriteLine("Invalid withdrawal amount.");
                }
            }

            // 👀 Read-only access to balance
            public decimal GetBalance()
            {
                return balance;
            }
        }

        class BankAccountSecurity
    {
            static void Main()
            {
                BankAccount account = new BankAccount(1000);

                account.Deposit(500);
                account.Withdraw(300);

                Console.WriteLine($"Current Balance: {account.GetBalance()}");
            }
        }
}
