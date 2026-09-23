using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using MsBox.Avalonia;
using MsBox.Avalonia.Base;
using MsBox.Avalonia.Enums;

namespace WpfRoutedEvents;

public partial class MainWindow : Window {
    public MainWindow() {
        InitializeComponent();
    }

    private static async Task MessageBox(string title, string msg) {
        IMsBox<ButtonResult> msgBox = MessageBoxManager.GetMessageBoxStandard(title, msg);

        ButtonResult result = await msgBox.ShowAsync();
    }

    private void BtnClickMe_OnClick(object? sender, RoutedEventArgs e) {
        // '_' => Discard the return value
        _ = MessageBox("Message Box", $"Clicked the button: {e.Source}");
    }


    private void OuterCircle_OnPointerPressed(object? sender, PointerPressedEventArgs e) {
        _ = MessageBox("Message Box", $"Clicked the circle: {e.Source}");

        // Stop bubbling
        e.Handled = true;
    }
}