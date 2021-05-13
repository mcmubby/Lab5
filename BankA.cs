namespace Lab5
{
    public class BankA : Bank
    {
        double balance = 100.00d;

        public override double GetBalance()
        {
            return balance;
        }
    }
}