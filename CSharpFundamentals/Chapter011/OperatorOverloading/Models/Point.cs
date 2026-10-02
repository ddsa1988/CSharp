namespace OperatorOverloading.Models;

internal class Point : IComparable<Point> {
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

    // Overload equality operators
    public static bool operator ==(Point p1, Point p2) {
        return p1.Equals(p2);
    }

    public static bool operator !=(Point p1, Point p2) {
        return !p1.Equals(p2);
    }

    // Overload comparison operators
    public static bool operator <(Point p1, Point p2) {
        return p1.CompareTo(p2) < 0;
    }

    public static bool operator >(Point p1, Point p2) {
        return p1.CompareTo(p2) > 0;
    }

    public static bool operator <=(Point p1, Point p2) {
        return p1.CompareTo(p2) <= 0;
    }

    public static bool operator >=(Point p1, Point p2) {
        return p1.CompareTo(p2) >= 0;
    }

    public override bool Equals(object? obj) {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj is not Point other) return false;

        return this.ToString() == other.ToString();
    }

    public override int GetHashCode() {
        return this.ToString().GetHashCode();
    }

    public override string ToString() {
        return $"[{nameof(X)}: {X}, {nameof(Y)}: {Y}]";
    }

    public int CompareTo(Point? other) {
        if (ReferenceEquals(this, other)) return 0;
        if (other is null) return 1;
        if (X > other.X && Y > other.Y) return 1;
        if (X < other.X && Y < other.Y) return -1;
        return 0;
    }
}