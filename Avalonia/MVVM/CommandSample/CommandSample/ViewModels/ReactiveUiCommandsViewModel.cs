using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using ReactiveUI;

namespace CommandSample.ViewModels;

public class ReactiveUiCommandsViewModel : ReactiveObject {
    private string? _robotName;
    public ObservableCollection<string> ConversationLog { get; } = [];
    public ICommand OpenThePodBayDoorDirectCommand { get; }
    public ICommand OpenThePodBayDoorByRobotCommand { get; }
    public ICommand OpenThePodBayDoorAsyncCommand { get; }

    public ReactiveUiCommandsViewModel() {
        OpenThePodBayDoorDirectCommand = ReactiveCommand.Create(OpenThePodBayDoor);

        IObservable<bool> canExecuteRobotCommand =
            this.WhenAnyValue(property => property.RobotName, (name) => !string.IsNullOrWhiteSpace(name));

        OpenThePodBayDoorByRobotCommand =
            ReactiveCommand.Create<string?>(OpenThePodBayDoorByRobot, canExecuteRobotCommand);

        OpenThePodBayDoorAsyncCommand = ReactiveCommand.CreateFromTask(OpenThePodBayDoorAsync);
    }

    private void AddToConversationLog(string content) {
        ConversationLog.Add(content);
    }

    public string? RobotName {
        get => _robotName;
        set => this.RaiseAndSetIfChanged(ref _robotName, value);
    }

    private void OpenThePodBayDoor() {
        ConversationLog.Clear();
        AddToConversationLog("I'm sorry, Dave, I'm afraid I can't do that.");
    }

    private void OpenThePodBayDoorByRobot(string? robotName) {
        ConversationLog.Clear();
        AddToConversationLog($"Hello {robotName}, the Pod Bay is open :-)");
    }

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