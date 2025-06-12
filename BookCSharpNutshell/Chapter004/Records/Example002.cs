namespace Chapter004.Records;

public static class Example002 {
    public static void Run() {
        /*
         The most important step that the compiler performs with all records is to write a copy constructor.
         This enables nondestructive mutation via the with keyword
         */

        var p1 = new Point(10, 20);
        Point p2 = p1 with { Y = 50 };

        Console.WriteLine("{0} => {1}", nameof(p1), p1);
        Console.WriteLine("{0} => {1}", nameof(p2), p2);
    }

    private record Point(int X, int Y);
}