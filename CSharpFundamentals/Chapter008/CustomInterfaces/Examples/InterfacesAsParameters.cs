using CustomInterfaces.Interfaces;
using CustomInterfaces.Models;

namespace CustomInterfaces.Examples;

internal static class InterfacesAsParameters {
    internal static void Run() {
        Shape[] shapes = [
            new Circle("Circle 1"),
            new Hexagon("Hexagon 1"),
            new Triangle("Triangle 1")
        ];

        foreach (Shape shape in shapes) {
            if (shape is not IPointy pointy) continue;

            PrintPointy(pointy);
        }
    }

    private static void PrintPointy(IPointy pointy) {
        Console.WriteLine($"Points = {pointy.Points}");
    }
}