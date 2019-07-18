namespace FactoryMethod
{
    partial class Program
    {
        // Concrete Product
        public class CitiSavingsAccount : SavingsAccount
        {
            public CitiSavingsAccount()
            {
                Balance = 5000;
            }
        }
    }
}
