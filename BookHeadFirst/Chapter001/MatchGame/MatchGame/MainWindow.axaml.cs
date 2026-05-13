using System;
using Avalonia.Controls;
using Avalonia.Input;
using MatchGame.Models;

namespace MatchGame;

public partial class MainWindow : Window {
    public MainWindow() {
        InitializeComponent();

        Game.SetUpGame(MainGrid);
    }

    private void TextBlockClicked(object? sender, PointerPressedEventArgs e) {
        var textBlock = sender as TextBlock;

        if (textBlock == null) return;

        Console.WriteLine("Clicked");
        // textBlock.Opacity = 1;
    }
}