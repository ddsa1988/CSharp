namespace CommandSample.ViewModels;

public partial class MainWindowViewModel : ViewModelBase {
    public ReactiveUiCommandsViewModel ReactiveUiCommandsViewModel { get; } = new();
    public CommunityToolkitCommandsViewModel CommunityToolkitCommandsViewModel { get; } = new();
}