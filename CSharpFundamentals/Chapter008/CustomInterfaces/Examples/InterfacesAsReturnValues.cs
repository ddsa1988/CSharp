using CustomInterfaces.Interfaces;
using CustomInterfaces.Models;

namespace CustomInterfaces.Examples;

internal static class InterfacesAsReturnValues {
    internal static void Run() {
        Shape[] shapes = [
            new Circle("Circle 1"),
            new Hexagon("Hexagon 1"),
            new Triangle("Triangle 1")
        ];

        IPointy? firstPointyItem = FindFirstPointyShape(shapes);

        Console.WriteLine($"The item has {firstPointyItem?.Points} points.");
    }

    private static IPointy? FindFirstPointyShape(Shape[] shapes) {
        foreach (Shape shape in shapes) {
            if (shape is not IPointy pointy) continue;

            return pointy;
        }

        return null;
    }
}