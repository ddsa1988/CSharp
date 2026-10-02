namespace OperatorOverloading.Models;

internal class Point {
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int xPos, int yPos) {
        X = xPos;
        Y = yPos;
    }

    public override string ToString() {
        return $"[{nameof(X)}: {X}, {nameof(Y)}: {Y}]";
    }
}