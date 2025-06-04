namespace Chapter003.TheObjectType;

public static class Example003 {
    public static void Run() {
        // The GetType Method is used on the instance
        // typeof Operator is used on a type name

        var point = new Point() { X = 10 };

        Console.WriteLine(point.GetType());
        Console.WriteLine(typeof(Point));
        Console.WriteLine(point.X.GetType());
    }

    private struct Point {
        public int X { get; set; }
    }
}