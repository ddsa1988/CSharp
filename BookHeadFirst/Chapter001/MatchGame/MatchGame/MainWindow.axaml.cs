using System;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Threading;
using MatchGame.Models;

namespace MatchGame;

public partial class MainWindow : Window {
    private readonly Game _game;
    private readonly DispatcherTimer _timer = new();
    private int _tenthsOfSecondsElapsed;

    public MainWindow() {
        InitializeComponent();

        _timer.Interval = TimeSpan.FromSeconds(0.1);
        _timer.Tick += TimerTick;

        _game = new Game(MainGrid);
        _timer.Start();
    }

    private void TimerTick(object? sender, EventArgs e) {
        _tenthsOfSecondsElapsed++;
        TimeTextBlock.Text = (_tenthsOfSecondsElapsed / 10F).ToString("0.0s");

        if (!_game.IsGameOver()) return;

        _timer.Stop();

        TimeTextBlock.Text += " - Play again?";
    }

    private void TimerPointerPressed(object? sender, PointerPressedEventArgs e) {
        if (!_game.IsGameOver()) return;

        _game.SetUpGame();
        _timer.Start();
        _tenthsOfSecondsElapsed = 0;
    }
}