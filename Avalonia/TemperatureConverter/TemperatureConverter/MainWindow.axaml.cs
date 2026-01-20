using System;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;

namespace TemperatureConverter;

public partial class MainWindow : Window {
    public MainWindow() {
        InitializeComponent();
    }

    private static double CelsiusToFahrenheit(double celsius) {
        double fahrenheit = celsius * (9d / 5d) + 32;
        return fahrenheit;
    }

    private void ConvertCelsiusToFahrenheit() {
        bool isDataValid = double.TryParse(Celsius.Text, out double celsius);

        if (isDataValid) {
            Fahrenheit.Text = CelsiusToFahrenheit(celsius).ToString("0.0");
        } else {
            Celsius.Text = "0.0";
            Fahrenheit.Text = "0.0";
        }
    }

    private void Button_OnClick(object sender, RoutedEventArgs e) {
        ConvertCelsiusToFahrenheit();
    }

    private void Celsius_OnKeyDown(object? sender, KeyEventArgs e) {
        bool isEnterPressed = e.Key == Key.Enter;

        if (!isEnterPressed) return;

        ConvertCelsiusToFahrenheit();
    }
}