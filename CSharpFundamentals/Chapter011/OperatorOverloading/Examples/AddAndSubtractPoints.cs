using OperatorOverloading.Models;

namespace OperatorOverloading.Examples;

internal static class AddAndSubtractPoints {
    public static void Run() {
        var p1 = new Point(10, 20);
        var p2 = new Point(30, 40);

        Console.WriteLine("{0}: {1}", nameof(p1), p1);
        Console.WriteLine("{0}: {1}", nameof(p2), p2);
    }
}