namespace Polymorphism.Models;

internal class Student : Person {
    public Guid Id { get; init; }

    public Student(string name) : base(name) {
        Id = Guid.NewGuid();
    }

    public new void Display() {
        Console.WriteLine($"Hello, {Name}. Your Id: {Id.ToString()}.");
    }
}