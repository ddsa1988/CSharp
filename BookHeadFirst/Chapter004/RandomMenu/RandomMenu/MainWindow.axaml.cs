using System;
using Avalonia.Controls;
using Avalonia.Layout;

namespace RandomMenu;

public partial class MainWindow : Window {
    public MainWindow() {
        InitializeComponent();

        MakeTheMenu();
    }

    private void MakeTheMenu() {
        int numberRows = MainGrid.RowDefinitions.Count;
        Console.WriteLine(numberRows);

        for (int i = 0; i < numberRows; i++) {
            var description = new TextBlock();
            var price = new TextBlock();

            Models.MenuItem.Generate();

            description.FontSize = 18;
            description.VerticalAlignment = VerticalAlignment.Center;
            description.Text = Models.MenuItem.Description;

            price.FontSize = 18;
            price.HorizontalAlignment = HorizontalAlignment.Center;
            price.VerticalAlignment = VerticalAlignment.Center;
            price.Text = Models.MenuItem.Price;

            Grid.SetRow(description, i);
            Grid.SetColumn(description, 0);

            Grid.SetRow(price, i);
            Grid.SetColumn(price, 1);

            MainGrid.Children.Add(description);
            MainGrid.Children.Add(price);
        }
    }
}