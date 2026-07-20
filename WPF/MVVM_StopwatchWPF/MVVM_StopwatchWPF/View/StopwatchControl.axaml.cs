using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Threading;
using MVVM_StopwatchWPF.ViewModel;

namespace MVVM_StopwatchWPF.View;

public partial class StopwatchControl : UserControl {
    private readonly DispatcherTimer _timer = new();
    private readonly StopwatchViewModel? _viewModel;

    public StopwatchControl() {
        InitializeComponent();

        _viewModel = Resources["ViewModel"] as StopwatchViewModel;

        _timer.Interval = TimeSpan.FromMilliseconds(100);
        _timer.Tick += TimerTick;
        _timer.Start();
    }

    private void TimerTick(object? sender, EventArgs e) {
        _viewModel?.OnPropertyChanged(string.Empty);
    }

    private void StartStopButtonClick(object? sender, RoutedEventArgs e) {
        _viewModel?.StartStop();
    }

    private void LapButtonClick(object? sender, RoutedEventArgs e) {
        _viewModel?.LapTime();
    }

    private void ResetButtonClick(object? sender, RoutedEventArgs e) {
        _viewModel?.Reset();
    }
}