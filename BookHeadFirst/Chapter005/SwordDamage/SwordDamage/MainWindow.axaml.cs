using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace SwordDamage;

public partial class MainWindow : Window {
    private readonly Models.SwordDamage _swordDamage = new();

    public MainWindow() {
        InitializeComponent();
    }

    private void ButtonOnClick(object? sender, RoutedEventArgs e) {
        bool isFlaming = Flaming.IsChecked ?? false;
        bool isMagic = Magic.IsChecked ?? false;

        int roll = Roll();
        int damage = _swordDamage.CalculateDamage(roll, isMagic, isFlaming);

        Damage.Text = $"Rolled {roll} for {damage} HP";
    }

    private static int Roll() {
        const int numberDices = 3;
        const int diceMinValue = 1;
        const int diceMaxValue = 6;

        int roll = 0;
        var random = new Random();

        for (int i = 0; i < numberDices; i++) {
            roll += random.Next(diceMinValue, diceMaxValue + 1);
        }

        return roll;
    }
}