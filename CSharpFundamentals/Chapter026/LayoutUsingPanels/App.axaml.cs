using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using LayoutUsingPanels.Panels;

namespace LayoutUsingPanels;

public partial class App : Application {
    public override void Initialize() {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted() {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop) {
            const int choice = 6;

            desktop.MainWindow = choice switch {
                0 => new SimpleCanvas(),
                1 => new SimpleWrapPanel(),
                2 => new SimpleStackPanel(),
                3 => new SimpleGridPanel(),
                4 => new SimpleGridPanelWithSplitter(),
                5 => new SimpleDockPanel(),
                6 => new SimpleScrollViwer(),
                _ => new MainWindow()
            };
        }

        base.OnFrameworkInitializationCompleted();
    }
}