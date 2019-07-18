namespace FactoryMethod
{
    partial class Program
    {
        // Creator
        interface ICreditUnionFactory
        {
            SavingsAccount GetSavingsAccount(string accountNumber);
        }
    }
}
