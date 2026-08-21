using System.Globalization;

namespace UsingStructs.Models;

internal readonly struct ReadOnlyPoint {
    public int X { get; }
    public int Y { get; }

    public ReadOnlyPoint(int x, int y) {
        X = x;
        Y = y;
    }

    public void Display() {
        Console.WriteLine($"X = {X}, Y = {Y}");
    }
}