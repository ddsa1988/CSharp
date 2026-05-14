using System;
using Avalonia.Controls;
using Avalonia.Input;
using MatchGame.Models;

namespace MatchGame;

public partial class MainWindow : Window {
    private readonly Game _game;

    public MainWindow() {
        InitializeComponent();

        _game = new Game(MainGrid);
        _game.SetUpGame();
    }

    private void TextBlockPressed(object? sender, PointerPressedEventArgs e) {
        var textBlock = sender as TextBlock;

        if (textBlock == null) return;

        _game.CheckGuess(textBlock);
    }
}