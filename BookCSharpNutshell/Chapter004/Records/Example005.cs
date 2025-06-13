namespace Chapter004.Records;

public static class Example005 {
    public static void Run() {
        // Property Validation

        var p1 = new Point(10, 20);
        Point p2 = p1 with { X = 50, Y = 100 };
        
        Console.WriteLine("{0} => {1}", nameof(p1), p1);
        Console.WriteLine("{0} => {1}", nameof(p2), p2);

        try {
            Point p3 = p1 with { X = double.NaN, Y = 50 };
        } catch (Exception ex) {
            Console.WriteLine(ex.Message);
        }
    }

    private record Point {
        private readonly double _x;

        public Point(double x, double y) {
            (X, Y) = (x, y);
        }

        public double X {
            get => _x;
            init {
                if (double.IsNaN(value)) {
                    throw new ArgumentException($"{nameof(X)} cannot be NaN");
                }

                _x = value;
            }
        }

        public double Y { get; init; }
    }
}