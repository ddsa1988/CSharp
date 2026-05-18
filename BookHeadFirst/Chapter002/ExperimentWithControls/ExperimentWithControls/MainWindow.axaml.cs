using System;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Interactivity;

namespace ExperimentWithControls;

public partial class MainWindow : Window {
    public MainWindow() {
        InitializeComponent();
    }

    private void NumberTextBox_OnTextChanged(object? sender, TextChangedEventArgs e) {
        var textBox = sender as TextBox;

        bool isNumeric = double.TryParse(textBox?.Text, out double number);

        if (!isNumeric) return;

        Number?.Text = $"{number}";
    }

    private void RadioButton_OnClick(object? sender, RoutedEventArgs e) {
        var radioButton = sender as RadioButton;

        bool isNumeric = double.TryParse(radioButton?.Content?.ToString(), out double number);

        if (!isNumeric) return;

        Number?.Text = $"{number}";
    }

    private void ListBox_OnSelectionChanged(object? sender, SelectionChangedEventArgs e) {
        var listBox = sender as ListBox;
        var listBoxItem = listBox?.SelectedItem as ListBoxItem;

        bool isNumeric = double.TryParse(listBoxItem?.Content?.ToString(), out double number);

        if (!isNumeric) return;

        Number?.Text = $"{number}";
    }

    private void ComboBox_OnSelectionChanged(object? sender, SelectionChangedEventArgs e) {
        var comboBox = sender as ComboBox;
        var comboBoxItem = comboBox?.SelectedItem as ComboBoxItem;

        bool isNumeric = double.TryParse(comboBoxItem?.Content?.ToString(), out double number);

        if (!isNumeric) return;

        Number?.Text = $"{number}";
    }

    private void ComboBoxEditable_OnSelectionChanged(object? sender, SelectionChangedEventArgs e) {
        var comboBox = sender as ComboBox;
        var comboBoxItem = comboBox?.SelectedItem as ComboBoxItem;

        bool isNumeric = double.TryParse(comboBoxItem?.Content?.ToString(), out double number);

        if (!isNumeric) return;

        Number?.Text = $"{number}";
    }

    private void Slider_OnValueChanged(object? sender, RangeBaseValueChangedEventArgs e) {
        var slider = sender as Slider;

        bool isNumeric = double.TryParse(slider?.Value.ToString("0"), out double number);

        if (!isNumeric) return;

        Number?.Text = $"{number}";
    }
}