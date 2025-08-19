using System.Collections.Generic;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Interactivity;
using PickRandomCardsUI.Models;

namespace PickRandomCardsUI;

public partial class MainWindow : Window {
    public MainWindow() {
        InitializeComponent();
    }

    private void SliderValueChanged(object? sender, RangeBaseValueChangedEventArgs e) {
        if (CardsAmount == null) return;

        CardsAmount.Text = NumberOfCards.Value.ToString("0");
    }

    private void ButtonClicked(object? sender, RoutedEventArgs e) {
        if (ListOfCards == null) return;

        IEnumerable<string> pickedCars = CardPicker.GetRandomCards((int)NumberOfCards.Value);

        ListOfCards.ItemsSource = pickedCars;
    }
}