namespace Chapter004.Tuples;

public static class Example005 {
    public static void Run() {
        // Equality Comparison

        (string name, int age) person1 = ("Person", 32);
        (string name, int age) person2 = ("Person", 32);

        Console.WriteLine("{0}.Equals({1}) = {2}", nameof(person1), nameof(person2), person1.Equals(person2));
    }
}