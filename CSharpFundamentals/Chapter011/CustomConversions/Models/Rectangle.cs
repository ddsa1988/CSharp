using System.Collections.Immutable;

namespace CustomConversions.Models;

internal class Rectangle {
    public int Width { get; set; }
    public int Height { get; set; }

    public Rectangle(int width, int height) {
        Width = width;
        Height = height;
    }

    public void Draw() {
        for (int i = 0; i < Height; i++) {
            for (int j = 0; j < Width; j++) {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }

    public override string ToString() {
        return $"[{nameof(Width)}: {Width}, {nameof(Height)}: {Height}]";
    }

    // Squares can be implicitly converted into Rectangles
    public static implicit operator Rectangle(Square square) {
        var rectangle = new Rectangle(square.Length, square.Length * 2);
        return rectangle;
    }
}