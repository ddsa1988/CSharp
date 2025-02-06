namespace Basics.S011_ObjectOrientedProgramming;

public class SavingAccount {
    // Static point of  data
    private static double interestRate;

    // Instance-level data
    public double Balance { get; private set; }

    // Static constructor
    static SavingAccount() {
        Console.WriteLine("Inside static constructor.");
        InterestRate = 0.04;
    }

    public SavingAccount(double initialBalance) {
        SetInitialBalance(initialBalance);
    }

    public static double InterestRate {
        get => interestRate;
        set => interestRate = value > 0 ? value : 0;
    }

    public void Deposit(double amount) {
        ArgumentOutOfRangeException.ThrowIfLessThanOrEqual(amount, 0, nameof(amount));

        Balance += amount;
    }

    public void Withdraw(double amount) {
        ArgumentOutOfRangeException.ThrowIfLessThanOrEqual(amount, 0, nameof(amount));

        double remainingBalance = Balance - amount;

        if (remainingBalance < 0) {
            throw new InvalidOperationException($"Insufficient balance.");
        }

        Balance = remainingBalance;
    }

    private void SetInitialBalance(double value) {
        Balance = value > 0 ? value : 0;
    }
}