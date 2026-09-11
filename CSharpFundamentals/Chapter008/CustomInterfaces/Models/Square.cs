using CustomInterfaces.Interfaces;

namespace CustomInterfaces.Models;

internal class Square : Shape, IRegularPointy {
    public Square() : this(string.Empty) { }

    public Square(string name) : base(name) { }

    // Draw comes from the Shape base class
    public override void Draw() {
        Console.WriteLine("Drawing a square.");
    }

    // This comes from the IPointy interface
    public byte Points => 4;

    // These come from the IRegularPointy interface
    public int SideLength { get; set; }
    public int NumberOfSides { get; set; }
}