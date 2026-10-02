namespace OperatorOverloading.Models;

internal class Point {
    public float X { get; set; }
    public float Y { get; set; }

    public Point(float xPos, float yPos) {
        X = xPos;
        Y = yPos;
    }

    // Overload unary operators '++' and '--'
    public static Point operator ++(Point p1) {
        return new Point(p1.X + 1, p1.Y + 1);
    }

    public static Point operator --(Point p1) {
        return new Point(p1.X - 1, p1.Y - 1);
    }

    // Overloaded operator '+'
    public static Point operator +(Point p1, Point p2) {
        return new Point(p1.X + p2.X, p1.Y + p2.Y);
    }

    public static Point operator +(Point p1, float change) {
        return new Point(p1.X + change, p1.Y + change);
    }

    // Overloaded operator '-'
    public static Point operator -(Point p1, Point p2) {
        return new Point(p1.X - p2.X, p1.Y - p2.Y);
    }

    // Overload operator '*'
    public static Point operator *(Point p1, Point p2) {
        return new Point(p1.X * p2.X, p1.Y * p2.Y);
    }

    // Overload operator '/'
    public static Point operator /(Point p1, Point p2) {
        return new Point(p1.X * p2.X, p1.Y * p2.Y);
    }

    public override string ToString() {
        return $"[{nameof(X)}: {X}, {nameof(Y)}: {Y}]";
    }
}