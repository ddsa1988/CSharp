namespace SimpleCasinoBlazor.Models;

public static class Game {
    private static readonly Random _random;
    private static readonly double _betMultiply;
    public static double Odds { get; private set; }
    public static double BetValue { get; set; }
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
        double pot = value * 2;

        Console.WriteLine(randomValue);
        Console.WriteLine(value);
    }
}