namespace Chapter002.Parameters;

public static class Example006 {
    public static void Run() {
        /*
            The in parameter is similar to a ref parameter except that the argument’s value
            cannot be modified by the method (doing so generates a compile-time error). This
            modifier is most useful when passing a large value type to the method because it
            allows the compiler to avoid the overhead of copying the argument prior to passing
            it in while still protecting the original value from modification.
         */

        var p1 = new Point() { X = 10, Y = 25 };

        PrintStruct(p1);
    }

    private static void PrintStruct(in Point point) {
        Console.WriteLine("{0} = {1}", nameof(point.X), point.X);
        Console.WriteLine("{0} = {1}", nameof(point.Y), point.Y);
    }

    private struct Point {
        public int X;
        public int Y;
    }
}