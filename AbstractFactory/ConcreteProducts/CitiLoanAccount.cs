using System;

namespace AbstractFactory.ConcreteProducts
{
    // Concrete Product B
    public class CitiLoanAccount : LoanAccount
    {
        public CitiLoanAccount() : base("Citi") { }
    }
}
