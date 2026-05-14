using System;
using Avalonia.Controls;
using Avalonia.Input;
using MatchGame.Models;

namespace MatchGame;

public partial class MainWindow : Window {
    public MainWindow() {
        InitializeComponent();

        var game = new Game(MainGrid);
        game.SetUpGame();
    }
}