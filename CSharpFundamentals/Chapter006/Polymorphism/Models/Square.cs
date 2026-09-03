namespace Polymorphism.Models;

internal class Square : Shape {
    public Square(string name) : base(name) { }

    public override void Draw() {
        Console.WriteLine($"The '{nameof(Square)}' named '{Name}' is drawing.");
    }
}