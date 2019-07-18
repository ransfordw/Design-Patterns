using System;

namespace FactoryMethod
{
    partial class Program
    {
        // Concrete Creator
        public class SavingsAccountFactory : ICreditUnionFactory
        {
            public SavingsAccount GetSavingsAccount(string accountNumber)
            {
                if (accountNumber.Contains("CITI"))
                    return new CitiSavingsAccount();
                else if (accountNumber.Contains("NATIONAL"))
                    return new NationalSavingsAccount();
                else
                    throw new ArgumentException("Invalid Account Number");
            }
        }
    }
}
