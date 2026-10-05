namespace CustomConversions.Models;

internal class Square {
    public int Length { get; }

    public Square(int length) {
        Length = length;
    }

    public void Draw() {
        for (int i = 0; i < Length; i++) {
            for (int j = 0; j < Length; j++) {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }

    public override string ToString() {
        return $"[{nameof(Length)}: {Length}]";
    }

    // Rectangle can be explicitly converted into Squares
    public static explicit operator Square(Rectangle rectangle) {
        var square = new Square(rectangle.Height);
        return square;
    }
}