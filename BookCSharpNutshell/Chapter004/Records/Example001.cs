namespace Chapter004.Records;

public static class Example001 {
    public static void Run() {
        /*
         A record is a special kind of class or struct that’s designed to work well with immutable (read-only) data.
         Its most useful feature is nondestructive mutation; however,records are also useful in creating types that
         just combine or hold data.
         */

        var p1 = new Point(10, 20);
        // p1.X = 10; // Compile-time error
        
        Console.WriteLine(p1);
        
        (int x, int y) = p1; // Deconstruct
        
        Console.WriteLine("{0} = {1}, {2} = {3}", nameof(x), x, nameof(y), y);
    }

    private record Point(int X, int Y);
}