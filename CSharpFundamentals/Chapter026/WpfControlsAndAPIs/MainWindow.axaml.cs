using Avalonia.Controls;
using Avalonia.Interactivity;
using DotNetCampus.Inking;
using SkiaSharp;

namespace WpfControlsAndAPIs;

public partial class MainWindow : Window {
    public MainWindow() {
        InitializeComponent();

        InkCanvas.AvaloniaSkiaInkCanvas.Settings.InkColor = new SKColor(0, 0, 255);

        InkCanvas.EditingMode = InkCanvasEditingMode.Ink;
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

    private void ComboColors_OnSelectionChanged(object? sender, SelectionChangedEventArgs e) { }
}