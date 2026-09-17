namespace ToDoList.Models;

internal class ToDoItem {
    public Guid Id { get; private set; }
    public DateTime CreatedOn { get; private set; }
    public DateTime ModifiedOn { get; private set; }

    public ToDoItem(string title, string description, bool isDone = false) {
        Id = Guid.NewGuid();
        CreatedOn = DateTime.Now;
        Title = title;
        Description = description;
        IsDone = isDone;
    }

    public string Title {
        get;
        set {
            if (string.IsNullOrWhiteSpace(value)) {
                throw new ArgumentException("Title cannot be null or whitespace.");
            }

            field = value;
            ModifiedOn = DateTime.Now;
        }
    }

    public string Description {
        get;
        set {
            if (string.IsNullOrWhiteSpace(value)) {
                throw new ArgumentException("Description cannot be null or whitespace.");
            }

            field = value;
            ModifiedOn = DateTime.Now;
        }
    }

    public bool IsDone {
        get;
        set {
            field = value;
            ModifiedOn = DateTime.Now;
        }
    }

    public override string ToString() {
        return
            $"Item {{ {nameof(Id)} = {Id}, {nameof(Title)} = {Title}, {nameof(Description)} = {Description}, {nameof(IsDone)} = {IsDone}, {nameof(CreatedOn)} = {CreatedOn}, {nameof(ModifiedOn)} = {ModifiedOn} }}";
    }
}