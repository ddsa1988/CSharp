using OperatorOverloading.Models;

namespace OperatorOverloading.Examples;

internal static class AddAndSubtractPoints {
    public static void Run() {
        const float addValue = 10f;

        var p1 = new Point(10, 20);
        var p2 = new Point(50, 70);

        Console.WriteLine("{0}: {1}", nameof(p1), p1);
        Console.WriteLine("{0}: {1}", nameof(p2), p2);

        Console.WriteLine();

        Console.WriteLine($"{nameof(p1)} + {nameof(p2)} = {p1 + p2}");
        Console.WriteLine($"{nameof(p1)} - {nameof(p2)} = {p1 - p2}");
        Console.WriteLine($"{nameof(p1)} + {addValue} = {p1 + addValue}");
    }
}