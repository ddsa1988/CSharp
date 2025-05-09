namespace Chapter003.Classes;

public static class Example008 {
    public static void UserMain() {
        /*
           Indexers provide a natural syntax for accessing elements in a class or struct that
           encapsulate a list or dictionary of values. Indexers are similar to properties but are
           accessed via an index argument rather than a property name.
         */

        const string str1 = "Example008";
        const string? str2 = null;

        Console.WriteLine(str1[0]);
        Console.WriteLine(str1[5]);

        Console.WriteLine(str2?[0]); // Writes nothing; no error.
    }
}