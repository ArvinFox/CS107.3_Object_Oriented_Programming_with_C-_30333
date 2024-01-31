using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_07
{
    internal class Program
    {
        static double balance = 1000;   // Initial balance

        static void CheckBalance()
        {
            Console.WriteLine($"Current Balance: ${balance}");
        }

        static void DepositMoney()
        {
            Console.WriteLine("Enter the amount to deposit: $");
            double depositAmount = Convert.ToDouble(Console.ReadLine());

            while (depositAmount <= 0)
            {
                Console.WriteLine("Invalid input. Enter a valid amount to deposit: $");
                depositAmount = Convert.ToDouble(Console.ReadLine());
            }

            balance += depositAmount;
            Console.WriteLine($"Deposit successful. New Balance: ${balance}");
        }

        static void WithdrawMoney()
        {
            Console.WriteLine("\nEnter the amount to withdraw: $");
            double withdrawAmount = Convert.ToDouble(Console.ReadLine());

            while (withdrawAmount <= 0 || withdrawAmount > balance)
            {
                if (withdrawAmount <= 0)
                {
                    Console.WriteLine("Invalid input. Enter a valid amount to withdraw: $");
                }
                else if (withdrawAmount > balance)
                {
                    Console.WriteLine("Insufficient funds. Enter a valid amount to withdraw: $");
                }

                withdrawAmount = Convert.ToDouble(Console.ReadLine());
            }

            balance -= withdrawAmount;
            Console.WriteLine($"Withdraw successful. New Balance: ${balance}");
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("ATM Simulation Menu: ");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter your choice (1-4): ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CheckBalance();
                        break;
                    case 2:
                        DepositMoney();
                        break;
                    case 3:
                        WithdrawMoney();
                        break;
                    case 4:
                        Console.WriteLine("Exiting ATM Simulation. Thank you!");
                        Console.ReadLine(); // Avoid closing the console
                        return;
                    default:
                        Console.WriteLine("Invalid input. Enter a valid choice (1-4): ");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
