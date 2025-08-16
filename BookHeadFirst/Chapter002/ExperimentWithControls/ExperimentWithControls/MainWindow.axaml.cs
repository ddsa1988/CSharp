using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Interactivity;

namespace ExperimentWithControls;

public partial class MainWindow : Window {
    public MainWindow() {
        InitializeComponent();
    }

    private void TextBoxChanged(object? sender, TextChangedEventArgs e) {
        if (Number == null) return;

        bool isNumberValid = int.TryParse(NumberTextBox.Text, out int number);

        Number.Text = isNumberValid ? number.ToString() : "0";
    }

    private void SliderValueChanged(object? sender, RangeBaseValueChangedEventArgs e) {
        if (Number == null) return;

        Number.Text = SmallSlider.Value.ToString("0");
    }

    private void RadioButtonChecked(object? sender, RoutedEventArgs e) {
        if (Number == null) return;

        var radioButton = sender as RadioButton;

        if (radioButton?.Content == null) return;

        Number.Text = radioButton.Content.ToString();
    }

    private void MyListBoxSelectionChanged(object? sender, SelectionChangedEventArgs e) {
        if (Number == null) return;

        var listBoxItem = MyListBox.SelectedItem as ListBoxItem;

        if (listBoxItem?.Content == null) return;

        Number.Text = listBoxItem.Content.ToString();
    }

    private void ReadOnlyComboBoxChanged(object? sender, SelectionChangedEventArgs e) {
        if (Number == null) return;

        var listBox = ReadOnlyComboBox.SelectedItem as ListBoxItem;

        if (listBox?.Content == null) return;

        Number.Text = listBox.Content.ToString();
    }
}