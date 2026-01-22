namespace BasicMvvmSample.ViewModels;

public partial class MainWindowViewModel : ViewModelBase {
    public SimpleViewModel SimpleViewModel { get; } = new();
    public ReactiveViewModel ReactiveViewModel { get; } = new();
}