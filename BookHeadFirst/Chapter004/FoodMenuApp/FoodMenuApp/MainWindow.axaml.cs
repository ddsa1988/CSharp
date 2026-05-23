using System;
using Avalonia.Controls;
using FoodMenuApp.Models;
using MenuItem = FoodMenuApp.Models.MenuItem;

namespace FoodMenuApp;

public partial class MainWindow : Window {
    public MainWindow() {
        InitializeComponent();

        MakeTheMenu(MainGrid);
    }

    private static void MakeTheMenu(Grid grid) {
        int numberOfItems = grid.RowDefinitions.Count;
        int numberOfColumns = grid.ColumnDefinitions.Count;

        if (numberOfItems == 0) return;
        if (numberOfColumns == 0) return;

        var menuItem = new MenuItem[numberOfItems];

        for (int i = 0; i < numberOfItems - 1; i++) {
            menuItem[i] = new MenuItem();

            switch (i) {
                case 3:
                case 4:
                    menuItem[i].Breads = ["plain bagel", "onion bagel", "pumpernickel bagel", "everything bagel"];
                    break;
                case 5:
                    menuItem[i].Proteins = ["Organic ham", "Mushroom patty", "Mortadella"];
                    menuItem[i].Breads = ["a gluten free roll", "a wrap", "pita"];
                    menuItem[i].Condiments = ["dijon mustard", "miso dressing", "au jus"];
                    break;
            }

            menuItem[i].Generate();

            TextBlock itemDescription = new();
            TextBlock itemPrice = new();

            itemDescription.Text = menuItem[i].Description;
            itemDescription.Classes.Add("item-description");

            itemPrice.Text = menuItem[i].Price;
            itemPrice.Classes.Add("item-price");

            Grid.SetRow(itemDescription, i);
            Grid.SetRow(itemPrice, i);

            Grid.SetColumn(itemDescription, 0);
            Grid.SetColumn(itemPrice, 1);

            grid.Children.Add(itemDescription);
            grid.Children.Add(itemPrice);
        }

        MenuItem guacamoleMenuItem = new();
        guacamoleMenuItem.Generate();

        TextBlock guacamoleItem = new();

        guacamoleItem.Text = $"Add guacamole for {guacamoleMenuItem.Price}";
        guacamoleItem.Classes.Add("item-guacamole");

        Grid.SetRow(guacamoleItem, numberOfItems - 1);
        Grid.SetColumn(guacamoleItem, 0);
        Grid.SetColumnSpan(guacamoleItem, numberOfColumns);

        grid.Children.Add(guacamoleItem);
    }
}