namespace Basics.S007_Structs.Models;

public struct Point {
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y) {
        X = x;
        Y = y;
    }

    public void Increment() {
        X++;
        Y++;
    }

    public void Decrement() {
        X--;
        Y--;
    }

    public void Display() {
        Console.WriteLine($"X: {X}, Y: {Y}");
    }
}