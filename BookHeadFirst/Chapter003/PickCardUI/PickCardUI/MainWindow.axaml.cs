using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Interactivity;
using PickCardUI.Models;

namespace PickCardUI;

public partial class MainWindow : Window {
    public MainWindow() {
        InitializeComponent();
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e) {
        if (NumberOfCards == null) return;

        ListOfCards.Items.Clear();

        string[] cardsPicked = CardPicker.PickSomeCards((int)NumberOfCards.Value);

        foreach (string card in cardsPicked) {
            ListOfCards.Items.Add(card);
        }
    }

    private void NumberOfCards_OnValueChanged(object? sender, RangeBaseValueChangedEventArgs e) {
        if (NumberOfCards == null) return;

        Number.Text = $"{NumberOfCards.Value}";
    }
}