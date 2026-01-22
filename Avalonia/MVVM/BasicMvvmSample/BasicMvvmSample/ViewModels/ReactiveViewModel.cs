using System;
using ReactiveUI;

namespace BasicMvvmSample.ViewModels;

public class ReactiveViewModel : ReactiveObject {
    public ReactiveViewModel() {
        this.WhenAnyValue(o => o.Name)!.Subscribe(new Action<object>(_ => this.RaisePropertyChanged(nameof(Greeting))));
    }

    private string? _name;

    public string? Name {
        get => _name;
        set => this.RaiseAndSetIfChanged(ref _name, value);
    }

    public string Greeting {
        get {
            if (string.IsNullOrWhiteSpace(Name)) {
                return "Hello World from Avalonia!";
            }

            return "Hello " + Name;
        }
    }
}