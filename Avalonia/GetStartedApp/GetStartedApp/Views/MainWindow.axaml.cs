using System.Diagnostics;
using System.Globalization;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using GetStartedApp.Models;

namespace GetStartedApp.Views;

public partial class MainWindow : Window {
    public MainWindow() {
        InitializeComponent();
    }

    public void Button_Click(object? sender, RoutedEventArgs e) {
        bool isDataValid = float.TryParse(Celsius.Text, out float celsius);

        if (!isDataValid) {
            Celsius.Text = "0";
            Fahrenheit.Text = "0";

            return;
        }

        float fahrenheit = ConvertTemperature.CelsiusToFahrenheit(celsius);
        
        Fahrenheit.Text = fahrenheit.ToString(CultureInfo.InvariantCulture);
    }
}