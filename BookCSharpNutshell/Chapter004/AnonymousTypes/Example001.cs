namespace Chapter004.AnonymousTypes;

public static class Example001 {
    public static void Run() {
        /*
             An anonymous type is a simple class created by the compiler on the fly to store a set of values.
             To create an anonymous type, use the new keyword followed by an object initializer, specifying
             the properties and values the type will contain.
             Anonymous types are immutable, so instances cannot be modified after creation.
         */

        const string name = "Amanda";
        const int age = 31;

        var p1 = new { Name = "Diego", Age = 37 };
        var p2 = new { Name = "Diego", Age = 37 };
        var p3 = new { name, age };

        Console.WriteLine(p1);
        Console.WriteLine(p2);
        Console.WriteLine(p3);

        Console.WriteLine();
        
        Console.WriteLine("{0}.Equals({1}) = {2}", nameof(p1), nameof(p2), p1.Equals(p2));
        Console.WriteLine("{0} == {1} = {2}", nameof(p1), nameof(p2), p1 == p2);
        
        Console.WriteLine("{0}.Equals({1}) = {2}", nameof(p1), nameof(p3), p1.Equals(p3));
        // Console.WriteLine("{0} == {1} = {2}", nameof(p1), nameof(p3), p1 == p3); // Compile-time error

        // p1.Name = "John"; // Compile-time error
    }
}