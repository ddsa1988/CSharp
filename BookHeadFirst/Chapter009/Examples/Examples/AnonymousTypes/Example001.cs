namespace Examples.AnonymousTypes;

public static class Example001 {
    public static void Run() {
        var whatAmI = new { Color = "Blue", Flavor = "Tasty", Height = 37 };
        Console.WriteLine(whatAmI);
    }
}