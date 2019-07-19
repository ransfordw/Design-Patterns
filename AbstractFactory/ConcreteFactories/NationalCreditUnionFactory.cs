using AbstractFactory.ConcreteProducts;

namespace AbstractFactory.ConcreteFactories
{
    // Concrete Factory 2
    public class NationalCreditUnionFactory : CreditUnionFactory
    {
        public override LoanAccount CreateLoanAccount()
        {
            return new NationalLoanAccount();
        }

        public override SavingsAccount CreateSavingsAccount()
        {
            return new NationalSavingsAccount();
        }
    }
}
