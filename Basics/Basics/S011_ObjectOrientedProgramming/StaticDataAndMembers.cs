using Basics.S011_ObjectOrientedProgramming.Models;

namespace Basics.S011_ObjectOrientedProgramming;

public static class StaticDataAndMembers {
    public static void UserMain() {
        Console.WriteLine($"Interest rate: {SavingAccount.InterestRate}");

        var acc1 = new SavingAccount(200);
        Console.WriteLine("Balance account 1: " + acc1.Balance);

        SavingAccount.InterestRate = 0.15;

        var acc2 = new SavingAccount(500);
        Console.WriteLine("Balance account 2: " + acc2.Balance);

        Console.WriteLine($"Interest rate: {SavingAccount.InterestRate}");
    }
}