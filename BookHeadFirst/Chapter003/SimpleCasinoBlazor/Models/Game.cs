namespace SimpleCasinoBlazor.Models;

public static class Game {
    private static readonly Random _random;
    private static readonly double _betMultiply;
    public static double Odds { get; private set; }
    public static double BetValue { get; set; }
    public static double DepositValue { get; set; }
    public static string TextResult { get; set; }
    public static Account Player { get; set; }

    static Game() {
        _random = new Random();
        _betMultiply = 2;
        Player = new Account("Player");
        TextResult = string.Empty;
        Odds = 0.75;

        InitGame();
    }

    public static void InitGame() {
        Player.Balance = 200;
        TextResult = string.Empty;
        BetValue = 0;
    }

    public static void Deposit(double value) {
        if (value <= 0) {
            TextResult = "The deposit value must be greater than zero!";
            return;
        }

        Player.Balance += value;
        TextResult = $"You deposit {value:C2}";
    }

    public static void Bet(double value) {
        if (value <= 0) {
            TextResult = "The bet value must be greater than zero.";
            return;
        }

        if (value > Player.Balance) {
            TextResult = "You don't have enough money for the bet.";
            return;
        }

        double randomValue = _random.NextDouble();
        double pot = value * _betMultiply;

        Player.Balance -= value;

        if (randomValue > Odds) {
            Player.Balance += pot;
            TextResult = $"You won {pot:C2}\n";
        } else {
            TextResult = "Bad luck, you lost.";
            TextResult += Player.Balance <= 0 ? " The house always wins!" : "";
        }
    }
}