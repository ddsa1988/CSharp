using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;

namespace Panels;

public partial class App : Application {
    public override void Initialize() {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted() {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop) {
            const int windowChoice = 3;

            desktop.MainWindow = windowChoice switch {
                0 => new Examples.StackPanelContainer(),
                1 => new Examples.WrapPanelContainer(),
                2 => new Examples.GridContainer(),
                3 => new Examples.CanvasContainer(),
                4 => new Examples.RelativePanelContainer(),
                _ => new Window(),
            };
        }

        base.OnFrameworkInitializationCompleted();
    }
}