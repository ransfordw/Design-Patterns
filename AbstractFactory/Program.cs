using System;
using System.Collections.Generic;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var accountNumbers = new List<string>
            {
                "CITI-456",
                "NATIONAL-987",
                "CHASE-222"
            };

            for (int i = 0; i < accountNumbers.Count; i++)
            {
                try
                {

                    CreditUnionFactory creditUnionFactory = CreditUnionFactoryProvider.GetCreditUnionFactory(accountNumbers[i]);
                    var loan = creditUnionFactory.CreateLoanAccount();
                    var savings = creditUnionFactory.CreateSavingsAccount();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
