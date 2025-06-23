using System.Diagnostics;

namespace Chapter004.Patterns;

public static class Example005 {
    public static void Run() {
        // Property Patterns
        // A property pattern (C# 8+) matches on one or more of an object’s property values.

        object obj = "Diego";

        if (obj is string { Length: >= 5 }) {
            Console.WriteLine(obj);
        }

        var p1 = new Person("Diego", "Alexandre");
        var p2 = new Person("diego", "Alexandre");

        Console.WriteLine(IsDiego(p1));
        Console.WriteLine(IsDiego(p2));
    }

    private static bool IsDiego(Person person) {
        return person switch {
            { FirstName: "Diego", LastName: "Alexandre" } => true,
            _ => false,
        };
    }

    private record Person(string FirstName, string LastName);
}