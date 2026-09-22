using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;

namespace MyWordPad;

public partial class MainWindow : Window {
    public MainWindow() {
        InitializeComponent();
    }

    private void ExitArea_OnPointerEntered(object? sender, PointerEventArgs e) { }

    private void ExitArea_OnPointerExited(object? sender, PointerEventArgs e) { }

    private void FileExit_OnClick(object? sender, RoutedEventArgs e) {
        Close();
    }

    private void ToolsHintsArea_OnPointerEntered(object? sender, PointerEventArgs e) { }

    private void ToolsHintsArea_OnPointerExited(object? sender, PointerEventArgs e) { }

    private void ToolsSpellingHints_OnClick(object? sender, RoutedEventArgs e) { }
}