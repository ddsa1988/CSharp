using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
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

    private void Slider1_OnValueChanged(object? sender, RangeBaseValueChangedEventArgs e) {
        if (sender is not Slider slider) return;

        Console.WriteLine("Slider: " + slider.Value);
    }

    private void SelectingItemsControl_OnSelectionChanged(object? sender, SelectionChangedEventArgs e) {
        if (sender is not ComboBox comboBox) return;

        if (comboBox.SelectedItem is not ComboBoxItem comboBoxItem) return;

        Console.WriteLine("Selection changed: " + comboBoxItem.Content);
    }
}