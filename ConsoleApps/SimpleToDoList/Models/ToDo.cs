namespace SimpleToDoList.Models;

public class ToDo {
    private string _description = string.Empty;
    public bool IsCompleted { get; set; }

    public ToDo(string description) {
        Description = description;
        IsCompleted = false;
    }

    public string Description {
        get => _description;
        set {
            if (string.IsNullOrEmpty(value.Trim())) {
                throw new ArgumentException("Description cannot be empty");
            }

            _description = value;
        }
    }

    public override string ToString() {
        return "Description: " + Description +
               ", IsCompleted: " + IsCompleted;
    }
}