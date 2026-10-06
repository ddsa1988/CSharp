using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace FirstApp;

public partial class MainWindow : Window {
    public MainWindow() {
        InitializeComponent();
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e) {
        MainText.Text = $"{nameof(sender)} = {sender}";

        if (sender is not Button button) return;

        MainText.Text += $"\n{nameof(button.Name)} = {button.Name}";
        MainText.Text += $"\n{nameof(button.Content)} = {button.Content}";
    }
}