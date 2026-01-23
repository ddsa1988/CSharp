using System.Collections.ObjectModel;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CommandSample.ViewModels;

public partial class CommunityToolkitCommandsViewModel : ObservableObject {
    [ObservableProperty] [NotifyCanExecuteChangedFor(nameof(OpenThePodBayDoorByRobotCommand))]
    private string? _robotName;

    public ObservableCollection<string> ConversationLog { get; } = [];

    private void AddToConversationLog(string content) {
        ConversationLog.Add(content);
    }

    [RelayCommand]
    private void OpenThePodBayDoorDirect() {
        ConversationLog.Clear();
        AddToConversationLog("I'm sorry, Dave, I'm afraid I can't do that.");
    }

    [RelayCommand(CanExecute = nameof(CanRobotOpenTheDoor))]
    private void OpenThePodBayDoorByRobot(string? robotName) {
        ConversationLog.Clear();
        AddToConversationLog($"Hello {robotName}, the Pod Bay is open :-)");
    }

    private bool CanRobotOpenTheDoor() => !string.IsNullOrWhiteSpace(RobotName);

    [RelayCommand]
    private async Task OpenThePodBayDoorAsync() {
        ConversationLog.Clear();

        AddToConversationLog("Preparing to open the Pod Bay...");
        await Task.Delay(1000);

        AddToConversationLog("Depressurizing Airlock...");
        await Task.Delay(2000);

        AddToConversationLog("Retracting blast doors...");
        await Task.Delay(2000);

        AddToConversationLog("Pod Bay is open to space.");
    }
}