using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;

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
        InitGame();
    }

    private void InitGame() {
        _randomNumber = GetRandomNumber(RandomMinValue, RandomMaxValue);
        _actualScore = StartScore;
        Guess.IsEnabled = true;
        BtnCheck.IsEnabled = true;
        Score.Text = $"💯 Score: {StartScore}";
        RangeNumber.Text = $"(Between {RandomMinValue} and {RandomMaxValue})";
        RandomNumber.Text = "?";
        Guess.Text = "";
        Message.Text = "Start guessing...";
        MainPanel.Background = new SolidColorBrush(Color.FromRgb(34, 34, 34));
        RandomNumber.Width = 80;
    }

    private void GameOver() {
        Guess.IsEnabled = false;
        BtnCheck.IsEnabled = false;
        BestScore.Text = "🥇 Best score: " + _bestScore;
        RandomNumber.Text = _randomNumber.ToString();
    }

    private static int GetRandomNumber(int minValue, int maxValue) {
        Random random = new();
        int randomNumber = random.Next(minValue, maxValue + 1);
        return randomNumber;
    }

    private void ClickBtnCheck(object? sender, RoutedEventArgs e) {
        bool isGuessValid = int.TryParse(Guess.Text, out int guessNumber) && guessNumber >= RandomMinValue &&
                            guessNumber <= RandomMaxValue;

        if (!isGuessValid) {
            Guess.Text = string.Empty;
            Message.Text = "⛔️ No number!";
            return;
        }

        if (guessNumber == _randomNumber) {
            if (_actualScore > _bestScore) {
                _bestScore = _actualScore;
            }

            Message.Text = "🎉 Correct Number!";
            MainPanel.Background = new SolidColorBrush(Color.FromRgb(96, 179, 71));
            RandomNumber.Width = 140;
            GameOver();
            return;
        }

        Score.Text = $"💯 Score: {--_actualScore}";
        Message.Text = guessNumber < _randomNumber ? "📉 Too low" : "📈 Too high!";

        if (_actualScore != 0) return;

        Message.Text = "💥 You lost the game!";
        GameOver();
    }

    private void ClickBtnAgain(object? sender, RoutedEventArgs e) {
        InitGame();
    }
}