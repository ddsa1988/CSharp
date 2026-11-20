namespace ObjectOrientedProgramming.Models.People;

internal class Student : Person {
    private readonly Guid _id;

    public Student(string name, DateOnly birthday) : base(name, birthday) {
        _id = Guid.CreateVersion7();
    }
}