namespace AbstractFactory
{
    // Abstract Factory
    public abstract class CreditUnionFactory
    {
        public abstract SavingsAccount CreateSavingsAccount();
        public abstract LoanAccount CreateLoanAccount();
    }
}
