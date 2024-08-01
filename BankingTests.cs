using StuffyBankLibrary;

namespace C_;

public class BankingTests
{
    [Fact]
    public void Test1()
    {
        Assert.True(true);
    }
    [Fact]
    public void Test2()
    {
        var account = new BankAccount("Kendra", 10000);
        Assert.Throws<InvalidOperationException>(
            ()=> account.MakeWithdrawal(75000,
            DateTime.Now,
            "Attempt to overdraw")
        );
    }
    [Fact]
    public void Test3()
    {
        Assert.Throws<ArgumentOutOfRangeException>(
            ()=> new BankAccount("Invalid",100)

        );
        



    }    
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