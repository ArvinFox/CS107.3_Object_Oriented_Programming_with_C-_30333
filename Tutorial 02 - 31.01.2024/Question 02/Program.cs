using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_02
{
    internal class Program
    {
        class BankAccount
        {
            public int AccountNumber;
            public double Balance;

            public void Deposit()
            {
                double i;
                Console.WriteLine("Enter the Amount you need to deposit: ");
                while (!double.TryParse(Console.ReadLine(), out i) || i<=0)
                {
                    Console.WriteLine("Not a Valid Amount!");
                }
                Balance += i;
                Console.WriteLine("New Balance: " + Balance);
            }
        }
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount();
            bankAccount.Balance = 1000;
            Console.WriteLine("Enter your Account number: ");
            while (!int.TryParse(Console.ReadLine(), out bankAccount.AccountNumber))
            {
                Console.WriteLine("\nEnter a Valid Account Number!\n");
            }
            bankAccount.Deposit();
            Console.ReadLine();
        }
    }
}
