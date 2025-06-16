namespace Chapter004.Records;

public static class Example006 {
    public static void Run() {
        /*
        A popular functional programming pattern that works well with immutable types is lazy evaluation,
        where a value is not computed until required and then is cached for reuse.
        */

        var p1 = new Point(2, 3);
        Point p2 = p1 with { Y = 4 };

        Console.WriteLine("{0} => {1}", nameof(p1), p1);
        Console.WriteLine("{0} => {1}", nameof(p2), p2);
    }

    private record Point {
        private readonly double _x;
        private readonly double _y;
        private double? _distance;

        public Point(double x, double y) {
            (X, Y) = (x, y);
        }

        public double X {
            get => _x;
            init {
                _x = value;
                _distance = null;
            }
        }

        public double Y {
            get => _y;
            init {
                _y = value;
                _distance = null;
            }
        }

        public double DistanceFromOrigin => _distance ??= Math.Sqrt(X * X + Y * Y);
    }
}