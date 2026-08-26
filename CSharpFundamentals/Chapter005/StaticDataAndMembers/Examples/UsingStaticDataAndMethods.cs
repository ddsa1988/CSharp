using StaticDataAndMembers.Models;

namespace StaticDataAndMembers.Examples;

internal static class UsingStaticDataAndMethods {
    public static void Run() {
        var s1 = new SavingAccount(50);
        Console.WriteLine("Interest rate: " + SavingAccount.GetInterestRate());

        var s2 = new SavingAccount(100);
        Console.WriteLine("Interest rate: " + SavingAccount.GetInterestRate());

        SavingAccount.SetInterestRate(0.15);

        var s3 = new SavingAccount(150);
        Console.WriteLine("Interest rate: " + SavingAccount.GetInterestRate());
    }
}