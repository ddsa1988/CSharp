namespace Basics.S007_Structs.Models;

public struct PointWithReadOnly {
    public readonly int X;
    public readonly int Y;
    public readonly string Name;

    public PointWithReadOnly(int x, int y, string name) {
        X = x;
        Y = y;
        Name = name;
    }

    public void Display() {
        Console.WriteLine($"X: {X}, Y: {Y}, Name: {Name}");
    }
}