using CloneablePoint.Models;

namespace CloneablePoint.Examples;

internal static class CloningObjects1 {
    internal static void Run() {
        var p1 = new PointWithValueTypes(50, 50);
        var p2 = p1.Clone() as PointWithValueTypes;

        Console.WriteLine($"{nameof(p1)} => {p1}");
        Console.WriteLine($"{nameof(p2)} => {p2}");
        Console.WriteLine();

        if (p2 == null) return;

        p2.X = 100;
        p2.Y = 100;

        Console.WriteLine($"{nameof(p1)} => {p1}");
        Console.WriteLine($"{nameof(p2)} => {p2}");
    }
}