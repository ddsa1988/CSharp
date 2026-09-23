using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.SpellChecker;

namespace MyWordPad;

public partial class MainWindow : Window {
    private readonly TextBoxSpellChecker _spellChecker;

    public MainWindow() {
        InitializeComponent();

        _spellChecker = new TextBoxSpellChecker(SpellCheckerConfig.Create("pt_BR", "en_GB"));
        var textBox = this.FindControl<TextBox>("TxtData");

        if (textBox == null) return;

        _spellChecker.Initialize(textBox);
    }

    private void ExitArea_OnPointerEntered(object? sender, PointerEventArgs e) {
        StatBarText.Text = "Exit the Application";
    }

    private void ExitArea_OnPointerExited(object? sender, PointerEventArgs e) {
        StatBarText.Text = "Ready";
    }

    private void FileExit_OnClick(object? sender, RoutedEventArgs e) {
        Close();
    }

    private void ToolsHintsArea_OnPointerEntered(object? sender, PointerEventArgs e) {
        StatBarText.Text = "Show Spelling Suggestions";
    }

    private void ToolsHintsArea_OnPointerExited(object? sender, PointerEventArgs e) { }

    private void ToolsSpellingHints_OnClick(object? sender, RoutedEventArgs e) {
        string spellingHints = string.Empty;

        Console.WriteLine(TxtData.CaretIndex);
    }
}