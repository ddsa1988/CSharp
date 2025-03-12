using Microsoft.AspNetCore.Components;

namespace SimpleAccountBlazor.Models;

public static class ManageAccount {
    public static double Amount { get; set; }
    public static Account Account { get; set; }

    static ManageAccount() {
        Account = new Account("Diego", 2000);
    }

    public static void Deposit(double amount) {
        Account.Balance += amount;
    }
    
    public static void Withdraw(double amount) {
        Account.Balance -= amount;
    }
}