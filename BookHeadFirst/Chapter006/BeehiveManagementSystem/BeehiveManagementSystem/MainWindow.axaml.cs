using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using BeehiveManagementSystem.Enums;
using BeehiveManagementSystem.Models;

namespace BeehiveManagementSystem;

public partial class MainWindow : Window {
    private readonly Queen _queen = new();

    public MainWindow() {
        InitializeComponent();

        StatusReport.Text = _queen.StatusReport;
    }

    private void AssignJobClick(object? sender, RoutedEventArgs e) {
        string? jobSelected = JobSelector?.Text?.Replace(" ", string.Empty);

        bool isJobValid = Enum.TryParse(jobSelected, out Job job);

        if (!isJobValid) return;

        _queen.AssignBee(job);

        StatusReport.Text = _queen.StatusReport;
    }

    private void WorkShiftClick(object? sender, RoutedEventArgs e) {
        _queen.WorkNextShift();

        StatusReport.Text = _queen.StatusReport;
    }
}