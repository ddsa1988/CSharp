using System.Drawing;
using Avalonia.Controls;
using Avalonia.Interactivity;
using DotNetCampus.Inking;
using SkiaSharp;

namespace WpfControlsAndAPIs;

public partial class MainWindow : Window {
    public MainWindow() {
        InitializeComponent();

        InkCanvas.EditingMode = InkCanvasEditingMode.Ink;
        InkCanvas.AvaloniaSkiaInkCanvas.Settings.InkColor = new SKColor(0, 0, 0);
        InkRadio.IsChecked = true;
        ComboColors.SelectedIndex = 0;
    }

    private void RadioButton_OnClick(object? sender, RoutedEventArgs e) {
        if (sender is not RadioButton radioButton) return;

        InkCanvas.EditingMode = radioButton.Content?.ToString() switch {
            "Ink Mode!" => InkCanvasEditingMode.Ink,
            "Erase Mode!" => InkCanvasEditingMode.EraseByPoint,
            _ => InkCanvasEditingMode.None
        };
    }

    private void ComboColors_OnSelectionChanged(object? sender, SelectionChangedEventArgs e) {
        if (ComboColors.SelectedItem is not StackPanel stackPanel) return;

        string colorToUse = stackPanel.Tag?.ToString() ?? "Black";
        Color color = Color.FromName(colorToUse);

        InkCanvas.AvaloniaSkiaInkCanvas.Settings.InkColor = new SKColor(color.R, color.G, color.B, 255);
    }

    private void BtnSave_OnClick(object? sender, RoutedEventArgs e) { }

    private void BtnLoad_OnClick(object? sender, RoutedEventArgs e) { }

    private void BtnClear_OnClick(object? sender, RoutedEventArgs e) { }
}