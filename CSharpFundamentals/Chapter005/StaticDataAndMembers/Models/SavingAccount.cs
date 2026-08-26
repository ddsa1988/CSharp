namespace StaticDataAndMembers.Models;

internal class SavingAccount {
    // Static data
    private static double _currentInterestRate;

    // Instance data
    private double _currentBalance;

    // Static constructor
    static SavingAccount() {
        SetInterestRate(0.04);
        Console.WriteLine("In static constructor");
    }

    public SavingAccount(double balance) {
        SetBalance(balance);
    }

    // Static methods
    public static void SetInterestRate(double interestRate) {
        _currentInterestRate = interestRate > 0 ? interestRate : 0;
    }

    public static double GetInterestRate() => _currentInterestRate;

    // Instance methods
    public void SetBalance(double balance) {
        _currentBalance = balance > 0 ? balance : 0;
    }

    public double GetBalance() => _currentBalance;
}