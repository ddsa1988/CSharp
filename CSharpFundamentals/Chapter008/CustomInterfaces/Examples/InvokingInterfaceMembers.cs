using CustomInterfaces.Interfaces;
using CustomInterfaces.Models;

namespace CustomInterfaces.Examples;

internal static class InvokingInterfaceMembers {
    internal static void Run() {
        Shape[] shapes = [
            new Circle("Circle 1"),
            new Hexagon("Hexagon 1"),
            new Triangle("Triangle 1")
        ];

        Console.WriteLine("Using 'try/catch':\n");

        foreach (Shape shape in shapes) {
            shape.Draw();

            try {
                var pointy = (IPointy)shape;
                Console.WriteLine($"Points: {pointy.Points}");
            }
            catch (InvalidCastException e) {
                Console.WriteLine(e.Message);
            }
            finally {
                Console.WriteLine();
            }
        }

        Console.WriteLine("Using the 'as' keyword:\n");

        foreach (Shape shape in shapes) {
            shape.Draw();

            var pointy = shape as IPointy;

            if (pointy == null) {
                Console.WriteLine();
                continue;
            }

            Console.WriteLine($"Points: {pointy.Points}\n");
        }

        Console.WriteLine("Using the 'is' keyword:\n");

        foreach (Shape shape in shapes) {
            shape.Draw();

            if (shape is not IPointy pointy) {
                Console.WriteLine();
                continue;
            }

            Console.WriteLine($"Points: {pointy.Points}\n");
        }
    }
}