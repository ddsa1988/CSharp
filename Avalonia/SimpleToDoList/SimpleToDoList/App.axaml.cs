using System;
using System.Collections.Generic;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Data.Core.Plugins;
using System.Linq;
using Avalonia.Markup.Xaml;
using SimpleToDoList.Models;
using SimpleToDoList.Services;
using SimpleToDoList.ViewModels;
using SimpleToDoList.Views;

namespace SimpleToDoList;

public partial class App : Application {
    private readonly MainWindowViewModel _mainWindowViewModel = new();
    private bool _canClose;
    
    public override void Initialize() {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted() {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop) {
            // Avoid duplicate validations from both Avalonia and the CommunityToolkit. 
            // More info: https://docs.avaloniaui.net/docs/guides/development-guides/data-validation#manage-validationplugins
            DisableAvaloniaDataAnnotationValidation();
            desktop.MainWindow = new MainWindow {
                DataContext = _mainWindowViewModel
            };

            // Listen to the ShutdownRequested-event
            desktop.ShutdownRequested += DesktopOnShutdownRequested;
        }

        base.OnFrameworkInitializationCompleted();
    }

    private static void DisableAvaloniaDataAnnotationValidation() {
        // Get an array of plugins to remove
        DataAnnotationsValidationPlugin[] dataValidationPluginsToRemove =
            BindingPlugins.DataValidators.OfType<DataAnnotationsValidationPlugin>().ToArray();

        // remove each entry found
        foreach (DataAnnotationsValidationPlugin plugin in dataValidationPluginsToRemove) {
            BindingPlugins.DataValidators.Remove(plugin);
        }
    }

    private async void DesktopOnShutdownRequested(object? sender, ShutdownRequestedEventArgs args) {
        try {
            args.Cancel = !_canClose;

            if (_canClose) return;

            IEnumerable<ToDoItem> itemsToSave = _mainWindowViewModel.ToDoItems.Select(item => item.GetToDoItem());

            await ToDoListFileService.SaveToFileAsync(itemsToSave);
        
            _canClose = true;

            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop) {
                desktop.Shutdown();
            }
        }
        catch (Exception ex) {
            Console.WriteLine(ex.Message);
        }
    }
}