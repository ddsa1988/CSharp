using System;
using Avalonia.Controls;
using Avalonia.Input;

namespace Controls.Views;

public partial class TextsWindow : Window {
    public TextsWindow() {
        InitializeComponent();

        FoodBox.ItemsSource = new string[] { "Pizza", "Caesar salad", "Hot dog", "Seafood" };
    }

    private void TextBox1_OnTextChanged(object? sender, TextChangedEventArgs e) {
        if (sender is not TextBox textBox) return;

        Console.WriteLine(textBox.Text);
    }
}