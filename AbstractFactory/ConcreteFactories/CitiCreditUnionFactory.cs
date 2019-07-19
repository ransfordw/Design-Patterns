using AbstractFactory.ConcreteProducts;

namespace AbstractFactory.ConcreteFactories
{
    public class CitiCreditUnionFactory : CreditUnionFactory
    {
        public override LoanAccount CreateLoanAccount()
        {
            return new CitiLoanAccount();
        }

        public override SavingsAccount CreateSavingsAccount()
        {
            return new CitiSavingsAccount();
        }
    }
}
