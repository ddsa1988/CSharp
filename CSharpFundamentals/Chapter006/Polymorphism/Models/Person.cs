namespace Polymorphism.Models;

internal class Person {
    public string Name { get; init; }

    public Person(string name) {
        Name = name;
    }

    public void Display() {
        Console.WriteLine($"Hello, {Name}.");
    }
}