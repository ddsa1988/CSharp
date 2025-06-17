namespace Chapter004.Records;

public static class Example008 {
    public static void Run() {
        /*
            Unlike with classes and structs, you do not (and cannot) override the object.Equals method;
            Instead, you define a public Equals method with the virtual signature, and it must be strongly
            typed such that it accepts the actual record type (Point in this case, not object).
        */
        
        var p1 = new Point(10, 20);
        var p2 = new Point(10, 20);

        Console.WriteLine("{0}.Equals({1}) => {2} ", nameof(p1), nameof(p2), p1.Equals(p2));
        Console.WriteLine("{0} == {1} => {2} ", nameof(p1), nameof(p2), p1 == p2);
    }

    private record Point(int X, int Y) {
        public override int GetHashCode() {
            return HashCode.Combine(X, Y);
        }

        public virtual bool Equals(Point? other) {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return X == other.X && Y == other.Y;
        }
    }
}