namespace UsingTuples.Examples;

internal static class DeconstructingTuples {
    internal static void Run() {
        {
            var myPoint1 = (10, 20);

            (int x, int y) myPoint2 = myPoint1;

            Console.WriteLine($"{myPoint2.x}, {myPoint2.y}");
        }

        Console.WriteLine();

        {
            var point = new Point(50, 60);

            (int x, int y) myPoint = point.Deconstruct();

            Console.WriteLine($"{myPoint.x}, {myPoint.y}");
        }
    }

    private class Point {
        public int X { get;  }
        public int Y { get; }

        public Point(int x, int y) {
            X = x;
            Y = y;
        }

        public (int x, int y) Deconstruct() => (X, Y);
    }
}