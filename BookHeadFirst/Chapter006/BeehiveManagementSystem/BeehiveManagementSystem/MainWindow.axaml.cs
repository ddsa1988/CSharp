using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using BeehiveManagementSystem.Enums;
using BeehiveManagementSystem.Models;
using Enumerable = System.Linq.Enumerable;

namespace BeehiveManagementSystem;

public partial class MainWindow : Window {
    private readonly Queen _queen = new();

    public MainWindow() {
        InitializeComponent();
        StatusReport.Text = _queen.StatusReport;
    }

    private void AssignJob_OnClick(object? sender, RoutedEventArgs e) {
        string jobName = string.Join("",
            JobSelector.SelectionBoxItem?.ToString()?.Split(" ") ?? Enumerable.Empty<string>());

        try {
            var job = (BeeJob)Enum.Parse(typeof(BeeJob), jobName);
            _queen.AssignBee(job);
            StatusReport.Text = _queen.StatusReport;
        } catch (Exception ex) {
            Console.WriteLine("Invalid job: " + ex.Message);
        }
    }

    private void WorkNextShift_OnClick(object? sender, RoutedEventArgs e) {
        _queen.WorkTheNextShift();
        StatusReport.Text = _queen.StatusReport;
    }
}