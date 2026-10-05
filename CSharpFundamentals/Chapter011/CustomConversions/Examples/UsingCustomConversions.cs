using CustomConversions.Models;

namespace CustomConversions.Examples;

internal static class UsingCustomConversions {
    public static void Run() {
        // Explicit cast
        {
            var rectangle = new Rectangle(15, 4);
            Console.WriteLine(rectangle);
            rectangle.Draw();

            Console.WriteLine();

            var square = (Square)rectangle;
            Console.WriteLine(square);
            square.Draw();
        }

        Console.WriteLine();

        // Implicit cast
        {
            var square = new Square(5);
            Rectangle rectangle = square;

            Console.WriteLine(rectangle);
            rectangle.Draw();
        }
    }
}