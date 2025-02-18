using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace SimpleToDoList.ViewModels;

public partial class MainViewModel : ViewModelBase {
    public ObservableCollection<ToDoItemViewModel> ToDoItems { get; } = new ObservableCollection<ToDoItemViewModel>();

    [ObservableProperty] [NotifyCanExecuteChangedFor(nameof(AddItemCommand))]
    private string? _newItemContent;

    private bool CanAddItem() {
        return !string.IsNullOrWhiteSpace(NewItemContent);
    }

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