namespace CastingOperations.Models;

internal class Circle : Shape {
    public Circle(string name) : base(name) { }

    public override void Draw() {
        Console.WriteLine($"The '{nameof(Circle)}' named '{Name}' is drawing.");
    }
}