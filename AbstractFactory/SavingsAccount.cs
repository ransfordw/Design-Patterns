using System;

namespace AbstractFactory
{
    public class SavingsAccount
    {
        public string BankName { get; set; }
        public SavingsAccount(string bankName)
        {
            BankName = bankName;
            Console.WriteLine($"Returned New Savings Account For {BankName} Bank.");
        }
    }
}
