using CloneablePoint.Models;

namespace CloneablePoint.Examples;

internal static class CloningObjects2 {
    internal static void Run() {
        var p1 = new PointWithReferenceTypes(50, 50, "Jane");
        var p2 = p1.Clone() as PointWithReferenceTypes;

        Console.WriteLine($"{nameof(p1)} => {p1}");
        Console.WriteLine($"{nameof(p2)} => {p2}");
        Console.WriteLine();

        if (p2 == null) return;

        p2.X = 100;
        p2.Y = 100;
        p2.Description.Name = "John Doe";

        Console.WriteLine($"{nameof(p1)} => {p1}");
        Console.WriteLine($"{nameof(p2)} => {p2}");
    }
}