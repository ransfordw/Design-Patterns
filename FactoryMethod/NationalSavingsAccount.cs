namespace FactoryMethod
{
    partial class Program
    {
        // Concrete Product
        public class NationalSavingsAccount : SavingsAccount
        {
            public NationalSavingsAccount()
            {
                Balance = 2000;
            }
        }
    }
}
