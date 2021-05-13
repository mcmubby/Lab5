using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            BankA firstBank = new BankA();
            BankB secondBank = new BankB();
            Bank thirdBank = new BankC();

            var firstBankBalance = firstBank.GetBalance();
            var secondBankBalance = secondBank.GetBalance();
            var thirdBankBalance = thirdBank.GetBalance();

            Console.WriteLine($"Bank A balance: {firstBankBalance} \nBank B balance: {secondBankBalance} \nBank C balance: {thirdBankBalance}");
        }
    }
}
