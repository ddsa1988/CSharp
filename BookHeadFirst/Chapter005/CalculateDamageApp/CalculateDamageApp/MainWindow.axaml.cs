using Avalonia.Controls;
using Avalonia.Interactivity;
using CalculateDamageApp.Models;

namespace CalculateDamageApp;

public partial class MainWindow : Window {
    private readonly SwordDamage _swordDamage = new();

    public MainWindow() {
        InitializeComponent();
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e) {
        _swordDamage.SetFlaming(Flaming?.IsChecked ?? false);
        _swordDamage.SetMagic(Magic?.IsChecked ?? false);
        _swordDamage.CalculateDamage();

        Damage.Text = $"Rolled {_swordDamage.Roll} for {_swordDamage.Damage} HP";
    }
}