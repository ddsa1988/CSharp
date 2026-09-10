using CustomInterfaces.Interfaces;

namespace CustomInterfaces.Models;

internal class Triangle : Shape, IPointy {
    public Triangle() : base(string.Empty) { }

    public Triangle(string name) : base(name) { }

    public override void Draw() {
        Console.WriteLine($"Drawing {Name} the Triangle.");
    }

    public byte Points => 3;
}