namespace UsingStructs.Models;

internal struct PointWithReadOnly {
    public int X { get; set; }
    public readonly int Y;
    public readonly string Name;

    public PointWithReadOnly(int x, int y, string name) {
        X = x;
        Y = y;
        Name = name;
    }

    public void Display() {
        Console.WriteLine($"X = {X}, Y = {Y}, Name = {Name}");
    }
}