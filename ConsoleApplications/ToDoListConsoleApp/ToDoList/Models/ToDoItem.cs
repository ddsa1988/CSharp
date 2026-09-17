namespace ToDoList.Models;

internal class ToDoItem {
    private readonly Guid _id;
    private readonly DateTime _createdOn;
    private DateTime _modifiedOn;

    public ToDoItem(string title, string description, bool isDone = false) {
        _id = Guid.NewGuid();
        _createdOn = DateTime.UtcNow;
        _modifiedOn = DateTime.UtcNow;

        Title = title;
        Description = description;
        IsDone = isDone;
    }

    public string Id => _id.ToString();
    public string CreatedOn => _createdOn.ToString("yyyy-MM-dd HH:mm:ss");
    public string ModifiedOn => _modifiedOn.ToString("yyyy-MM-dd HH:mm:ss");

    public string Title {
        get;
        set {
            if (string.IsNullOrWhiteSpace(value)) {
                throw new ArgumentException("Title cannot be null or whitespace.");
            }

            field = value;
            _modifiedOn = DateTime.UtcNow;
        }
    }

    public string Description {
        get;
        set {
            if (string.IsNullOrWhiteSpace(value)) {
                throw new ArgumentException("Description cannot be null or whitespace.");
            }

            field = value;
            _modifiedOn = DateTime.UtcNow;
        }
    }

    public bool IsDone {
        get;
        set {
            field = value;
            _modifiedOn = DateTime.UtcNow;
        }
    }

    public override string ToString() {
        return
            $"Item {{ {nameof(Id)} = {Id}, {nameof(Title)} = {Title}, {nameof(Description)} = {Description}, {nameof(IsDone)} = {IsDone}, {nameof(CreatedOn)} = {CreatedOn}, {nameof(ModifiedOn)} = {ModifiedOn} }}";
    }
}