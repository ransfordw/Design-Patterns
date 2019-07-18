using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new SavingsAccountFactory() as ICreditUnionFactory;
            var citiAccount = factory.GetSavingsAccount("CITI-321");
            var nationalAccount = factory.GetSavingsAccount("NATIONAL-987");
            Console.WriteLine($"My citi balance is ${citiAccount.Balance} " +
                $"and national balance is ${nationalAccount.Balance}");
        }

        // Product
        public abstract class SavingsAccount
        {
            public decimal Balance { get; set; }
        }

        // Concrete Product
        public class CitiSavingsAccount : SavingsAccount
        {
            public CitiSavingsAccount()
            {
                Balance = 5000;
            }
        }

        // Concrete Product
        public class NationalSavingsAccount : SavingsAccount
        {
            public NationalSavingsAccount()
            {
                Balance = 2000;
            }
        }

        // Creator
        interface ICreditUnionFactory
        {
            SavingsAccount GetSavingsAccount(string accountNumber);
        }

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
