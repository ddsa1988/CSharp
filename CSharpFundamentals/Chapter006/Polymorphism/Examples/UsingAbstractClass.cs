using Polymorphism.Models;

namespace Polymorphism.Examples;

internal static class UsingAbstractClass {
    internal static void Run() {
        Shape[] shapes = [
            new Circle("Circle 1"),
            new Square("Square 1"),
            new Square("Square 2"),
            new Circle("Circle 2"),
            new Square("Square 3")
        ];

        foreach (Shape shape in shapes) {
            shape.Draw();
        }
    }
}