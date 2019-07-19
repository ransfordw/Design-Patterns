using AbstractFactory.ConcreteFactories;
using System;

namespace AbstractFactory
{
    public class CreditUnionFactoryProvider
    {
        public static CreditUnionFactory GetCreditUnionFactory(string accountNumber)
        {
            if (accountNumber.Contains("CITI")) return new CitiCreditUnionFactory();
            else if (accountNumber.Contains("NATIONAL")) return new NationalCreditUnionFactory();
            else
                throw new InvalidOperationException("Account Number was invalid");
        }
    }
}
