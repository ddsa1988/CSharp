using Avalonia.Controls;
using Avalonia.Input;
using MatchGame.Models;

namespace MatchGame;

public partial class MainWindow : Window {
    private readonly Game Game;

    public MainWindow() {
        InitializeComponent();

        Game = new Game(MainGrid);
        Game.SetUpGame();
    }

    private void TextBlockClicked(object? sender, PointerPressedEventArgs e) {
        var textBlock = sender as TextBlock;

        if (textBlock == null) return;
    }
}