using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Controls.Views;

public partial class ValueSelectionWindow : Window {
    public ValueSelectionWindow() {
        InitializeComponent();
    }

    private void CheckBox1_OnIsCheckedChanged(object? sender, RoutedEventArgs e) {
        if (sender is not CheckBox checkBox) return;

        Console.WriteLine("Is checked: " + checkBox.IsChecked);
    }
}