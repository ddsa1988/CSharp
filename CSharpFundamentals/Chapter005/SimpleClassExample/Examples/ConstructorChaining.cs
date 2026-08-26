using SimpleClassExample.Models;

namespace SimpleClassExample.Examples;

internal static class ConstructorChaining {
    internal static void Run() {
        var m1 = new Motorcycle();
        Console.WriteLine();

        var m2 = new Motorcycle("Diego");
        Console.WriteLine();

        var m3 = new Motorcycle(20);
        Console.WriteLine();

        var m4 = new Motorcycle("Diego", 70);
    }
}