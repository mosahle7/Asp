using System;
using StuffyBankLibrary;
using Humanizer;
namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {

            var account = new BankAccount("Kendra",10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}");
            account.MakeWithdrawal(1980,DateTime.Now,"sdjd");
            Console.WriteLine(account.Balance);
            account.MakeWithdrawal(50,DateTime.Now,"XBOX game");
            Console.WriteLine(account.Balance);

            Console.WriteLine(account.GetAccountHistory());

         // Test that the initial balances must be positive.
        //    try
        //     {
        //         var invalidAccount = new BankAccount("invalid", -55);
        //    }
        //  catch (ArgumentOutOfRangeException e)
        //    {
        //         Console.WriteLine("Exception caught creating account with negative balance");
        //         Console.WriteLine(e.ToString());
        //     }

        // Test for a negative balance.
        //    try
        //    {
        //         account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
        //     }
        //     catch (InvalidOperationException e)
        //     {
        //         Console.WriteLine("Exception caught trying to overdraw");
        //         Console.WriteLine(e.ToString());
        //     }

        
        }
    }
}
