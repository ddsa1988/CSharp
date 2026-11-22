using ObjectOrientedProgramming.Utils;

namespace ObjectOrientedProgramming.Models.People;

internal class Student : Person {
    private readonly Guid _id;
    private readonly string _course = string.Empty;

    public Student(string name, DateOnly birthday, string course) : base(name, birthday) {
        _id = Guid.CreateVersion7();
        Course = course;
    }

    public string Id => _id.ToString();

    public string Course {
        get => _course;
        init {
            if (string.IsNullOrWhiteSpace(value)) {
                throw new ArgumentException("Argument can't be null or empty", nameof(value));
            }

            _course = value.ToTitleCase();
        }
    }

    public override string ToString() {
        return $"Student [{nameof(Name)} = {Name}, {nameof(Id)} = {Id}, {nameof(Course)} = {Course}]";
    }
}