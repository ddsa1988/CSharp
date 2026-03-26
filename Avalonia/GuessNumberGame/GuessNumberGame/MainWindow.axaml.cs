using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace GuessNumberGame;

public partial class MainWindow : Window {
    private const int RandomMinValue = 1;
    private const int RandomMaxValue = 20;
    private const int StartScore = 20;
    private int _randomNumber;
    private int _actualScore;
    private int _bestScore;

    public MainWindow() {
        InitializeComponent();
    }

    private void SetupGame() {
        RandomRange.Text = $"Between {RandomMinValue} and {RandomMaxValue}";
        _randomNumber = GetRandomNumber(RandomMinValue, RandomMaxValue);
        _actualScore = StartScore;
    }

    private static int GetRandomNumber(int minValue, int maxValue) {
        Random random = new();
        int randomNumber = random.Next(minValue, maxValue + 1);
        return randomNumber;
    }

    private void ButtonCheck(object? sender, RoutedEventArgs e) {
        bool isGuessValid = int.TryParse(Guess.Text, out int guessNumber) && guessNumber >= RandomMinValue &&
                            guessNumber <= RandomMaxValue;

        if (!isGuessValid) {
            Guess.Text = string.Empty;
            Message.Text = "⛔️ No number!";
            return;
        }
    }

    private void ButtonAgain(object? sender, RoutedEventArgs e) {
        throw new System.NotImplementedException();
    }

    // "📉 Too low" : "📈 Too high!"
    // "💥 You lost the game!"
}