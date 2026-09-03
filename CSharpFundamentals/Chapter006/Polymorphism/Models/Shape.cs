namespace Polymorphism.Models;

internal abstract class Shape {
    public string Name { get; init; }

    protected Shape(string name) {
        Name = name;
    }

    public abstract void Draw();
}