using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Feb3
{
    public class BankAccount
    {
        public string AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public decimal Balance { get; set; }
        public BankAccount(string accountNumber, string accounHolderName, decimal balance)
        {
            AccountNumber = accountNumber;
            AccountHolderName = accounHolderName;
            Balance = balance;
        }
        public void Deposit(decimal balance)
        {
            if(balance > 0)
            {
                Balance += balance;
                Console.WriteLine($"Balance {balance} deposited successfully. New balance {Balance}");
            }
            else
            {
                Console.WriteLine("Amount should be greater than 0");
            }
        }

        public void Withdraw(decimal balance)
        {
            if(balance > 0 && balance <= Balance)
            {
                Balance -= balance;
                Console.WriteLine($"Balance {balance} withdrawn successfully. Remaining balance:{Balance}");
            }
        }
        public void DisplayAccountDetails()
        {
            Console.WriteLine("====================================");
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Account Holder: {AccountHolderName}");
            Console.WriteLine($"Balance: {Balance}");
            Console.WriteLine("====================================");
        }

    }
}
