using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BasicMvvmSample.ViewModels;

public class SimpleViewModel : INotifyPropertyChanged {
    private string? _name;
    public event PropertyChangedEventHandler? PropertyChanged;

    private void RaisePropertyChanged([CallerMemberName] string? propertyName = null) {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public string? Name {
        get => _name;
        set {
            if (value == _name) return;

            _name = value;
            RaisePropertyChanged();
            RaisePropertyChanged(nameof(Greeting));
        }
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