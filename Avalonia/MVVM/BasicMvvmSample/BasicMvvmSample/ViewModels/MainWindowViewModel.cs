namespace BasicMvvmSample.ViewModels;

public partial class MainWindowViewModel : ViewModelBase {
    public SimpleViewModel SimpleViewModel { get; } = new();
}