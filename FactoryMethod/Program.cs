using System;

namespace FactoryMethod
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var factory = new SavingsAccountFactory() as ICreditUnionFactory;
            var citiAccount = factory.GetSavingsAccount("CITI-321");
            var nationalAccount = factory.GetSavingsAccount("NATIONAL-987");
            Console.WriteLine($"My citi balance is ${citiAccount.Balance} " +
                $"and national balance is ${nationalAccount.Balance}");
        }
    }
}
