using System;
using System.Globalization;
using Avalonia.Controls;

namespace ExperimentWithControls;

public partial class MainWindow : Window {
    public MainWindow() {
        InitializeComponent();
    }

    private void NumberTextBox_OnTextChanged(object? sender, TextChangedEventArgs e) {
        var textBox = sender as TextBox;

        if (textBox is null) return;

        bool isNumeric = double.TryParse(textBox.Text, out double number);

        if (!isNumeric) return;

        Number.Text = $"{number}";
    }
}