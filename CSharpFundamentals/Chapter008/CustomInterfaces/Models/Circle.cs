namespace CustomInterfaces.Models;

internal class Circle : Shape {
    public Circle() : this(string.Empty) { }

    public Circle(string name) : base(name) { }

    public override void Draw() {
        Console.WriteLine($"Drawing {Name} the Circle.");
    }
}