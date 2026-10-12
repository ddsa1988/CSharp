using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Panels.Examples;

namespace Panels;

public partial class App : Application {
    public override void Initialize() {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted() {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop) {
            const int windowChoice = 6;

            desktop.MainWindow = windowChoice switch {
                0 => new Examples.StackPanelContainer(),
                1 => new Examples.WrapPanelContainer(),
                2 => new Examples.GridContainer(),
                3 => new Examples.CanvasContainer(),
                4 => new Examples.RelativePanelContainer(),
                5 => new Examples.DockPanelContainer(),
                6 => new ResponsiveLayout(),
                _ => new Window(),
            };
        }

        base.OnFrameworkInitializationCompleted();
    }
}