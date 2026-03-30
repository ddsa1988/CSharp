using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace SimpleToDoList.ViewModels;

public partial class MainWindowViewModel : ViewModelBase {
    // This attribute will invalidate the command each time this property changes
    [ObservableProperty] [NotifyCanExecuteChangedFor(nameof(AddItemCommand))]
    private string? _newItemContent;

    private ObservableCollection<ToDoItemViewModel> ToDoItems { get; } = [];

    // Returns if a new Item can be added. We require to have the NewItem some Text
    private bool CanAddItem() => !string.IsNullOrWhiteSpace(NewItemContent);

    [RelayCommand(CanExecute = nameof(CanAddItem))]
    private void AddItem() {
        ToDoItems.Add(new ToDoItemViewModel() { Content = NewItemContent });

        NewItemContent = null;
    }

    [RelayCommand]
    private void RemoveItem(ToDoItemViewModel item) {
        ToDoItems.Remove(item);
    }
}