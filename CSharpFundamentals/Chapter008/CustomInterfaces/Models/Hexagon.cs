using CustomInterfaces.Interfaces;

namespace CustomInterfaces.Models;

internal class Hexagon : Shape, IPointy {
    public Hexagon() : this(string.Empty) { }

    public Hexagon(string name) : base(name) { }

    public override void Draw() {
        Console.WriteLine($"Drawing {Name} the Hexagon.");
    }

    public byte Points => 6;
}