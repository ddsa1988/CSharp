using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Controls.Views;

namespace Controls;

public partial class App : Application {
    public override void Initialize() {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted() {
        const int userChoice = 0;

        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop) {
            desktop.MainWindow = userChoice switch {
                0 => new ButtonsWindow(),
                _ => new MainWindow()
            };
        }

        base.OnFrameworkInitializationCompleted();
    }
}