namespace UsingStructs.Models;

internal class Point {
    public int X { get; set; } = 7;
    public int Y { get; set; } = 10;

    // Default constructor
    public Point() {
        // X = 0;
        // Y = 0;
    }

    // Custom constructor
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
        Console.WriteLine($"X = {X}, Y = {Y}");
    }
}