namespace Basics.S007_Structs.Models;

public struct ReadOnlyPoint {
    public int X { get; }
    public int Y { get; }
    public string Name { get; }

    public ReadOnlyPoint(int x, int y, string name) {
        X = x;
        Y = y;
        Name = name;
    }

    public void Display() {
        Console.WriteLine($"X: {X}, Y: {Y}, Name: {Name}");
    }
}