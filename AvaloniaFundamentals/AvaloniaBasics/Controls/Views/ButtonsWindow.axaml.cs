using System;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Interactivity;

namespace Controls.Views;

public partial class ButtonsWindow : Window {
    public ButtonsWindow() {
        InitializeComponent();
    }

    private void Button1_OnClick(object? sender, RoutedEventArgs e) {
        Console.WriteLine(sender);
        Console.WriteLine(e);
        Console.WriteLine(e.Source);
        Console.WriteLine(e.Handled);
    }

    private void RepeatButton1_OnClick(object? sender, RoutedEventArgs e) {
        Console.WriteLine(sender);
        Console.WriteLine(e);
        Console.WriteLine(e.Source);
        Console.WriteLine(e.Handled);
    }

    private void ToggleButton1_OnClick(object? sender, RoutedEventArgs e) {
        Console.WriteLine(sender);
        Console.WriteLine(e);
        Console.WriteLine(e.Source);
        Console.WriteLine(e.Handled);

        if (sender is not ToggleButton toggleButton) return;

        Console.WriteLine(toggleButton.IsChecked);
    }

    private void RadioButton_OnIsCheckedChanged(object? sender, RoutedEventArgs e) {
        if (sender is not RadioButton radioButton) return;

        Console.WriteLine(radioButton.Name);
        Console.WriteLine(radioButton.GroupName);
        Console.WriteLine(radioButton.IsChecked);

        e.Handled = true;
    }

    private void ButtonSpinner1_OnSpin(object? sender, SpinEventArgs e) {
        if (sender is not ButtonSpinner buttonSpinner) return;

        bool isContentValid = int.TryParse(buttonSpinner.Content?.ToString(), out int value);

        if (!isContentValid) return;

        if (e.Direction == SpinDirection.Increase) {
            value++;
        }
        else {
            value--;
        }

        buttonSpinner.Content = value.ToString();
    }
}