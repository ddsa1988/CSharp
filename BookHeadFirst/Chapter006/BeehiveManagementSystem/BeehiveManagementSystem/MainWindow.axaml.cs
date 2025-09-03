using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace BeehiveManagementSystem;

public partial class MainWindow : Window {
    public MainWindow() {
        InitializeComponent();
    }

    private void AssignJob_OnClick(object? sender, RoutedEventArgs e) {
        Console.WriteLine("AssignJob_OnClick");
        Console.WriteLine(Models.HoneyVault.StatusReport);
    }

    private void WorkNextShift_OnClick(object? sender, RoutedEventArgs e) {
        Console.WriteLine("WorkNextShift_OnClick");
    }
}