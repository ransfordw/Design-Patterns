using System;

namespace AbstractFactory
{
    public class LoanAccount
    {
        public string BankName { get; set; }
        public LoanAccount(string bankName)
        {
            BankName = bankName;
            Console.WriteLine($"Returned New Loan Account For {BankName} Bank.");
        }
    }
}
