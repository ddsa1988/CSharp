using System.Globalization;
using Avalonia.Controls;
using Avalonia.Interactivity;
using GetStartedApp.Models;

namespace GetStartedApp.Views;

public partial class MainWindow : Window {
    public MainWindow() {
        InitializeComponent();
    }

    public void Btn_Calculate(object? sender, RoutedEventArgs e) {
        bool isDataValid = float.TryParse(Celsius.Text, out float celsius);

        if (!isDataValid) {
            Celsius.Text = "0";
            Fahrenheit.Text = "0";

            return;
        }

        float fahrenheit = ConvertTemperature.CelsiusToFahrenheit(celsius);

        Fahrenheit.Text = fahrenheit.ToString(CultureInfo.InvariantCulture);
    }

    private void Btn_GridLines(object? sender, RoutedEventArgs e) {
        Grid.ShowGridLines = !Grid.ShowGridLines;
    }

    private void Celsius_TextChanged(object? sender, TextChangedEventArgs e) {
        bool isDataValid = float.TryParse(Celsius.Text, out float celsius);

        if (!isDataValid) return;

        float fahrenheit = ConvertTemperature.CelsiusToFahrenheit(celsius);

        Fahrenheit.Text = fahrenheit.ToString(CultureInfo.InvariantCulture);
    }
}