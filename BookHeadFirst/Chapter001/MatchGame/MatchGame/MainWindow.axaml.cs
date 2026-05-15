using Avalonia.Controls;
using Avalonia.Input;
using MatchGame.Models;

namespace MatchGame;

public partial class MainWindow : Window {
    private readonly Game _game;

    public MainWindow() {
        InitializeComponent();

        _game = new Game(MainGrid, TimeTextBlock);
    }

    private void TimerPointerPressed(object? sender, PointerPressedEventArgs e) {
        if (!_game.IsGameOver()) return;

        _game.SetUpGame();
    }
}