using UsingStructs.Models;

namespace UsingStructs.Examples;

internal static class CreatingStructs {
    internal static void Run() {
        Point p1 = new() { X = 349, Y = 76 };
        p1.Display();

        p1.Increment();
        p1.Display();

        p1.X = 700;
        p1.Y = 900;

        p1.Display();

        Console.WriteLine();

        Point p2 = new(50, 60);
        p2.Display();

        Console.WriteLine();

        Point p3 = new();
        p3.Display();

        Console.WriteLine();

        ReadOnlyPoint p4 = new(78, 21);
        p4.Display();

        // p4.X = 10; // Error: property has no setter
        // p4.Y = 20; // Error: property has no setter

        Console.WriteLine();

        PointWithReadOnly p5 = new(36, 41, "Point W/RO");
        p5.Display();
    }
}