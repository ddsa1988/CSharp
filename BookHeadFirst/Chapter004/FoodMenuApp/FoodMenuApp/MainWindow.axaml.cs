using System;
using Avalonia.Controls;
using FoodMenuApp.Models;

namespace FoodMenuApp;

public partial class MainWindow : Window {
    public MainWindow() {
        InitializeComponent();

        var menuItems = new MenuItems();
    }
}