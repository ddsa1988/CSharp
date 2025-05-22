namespace Chapter003.Generics;

public static class Example002 {
    public static void UserMain() {
        // A generic method declares type parameters within the signature of a method.

        int x = 20;
        int y = 30;

        string name1 = "Diego";
        string name2 = "Amanda";

        Console.WriteLine("Before swap: ");

        Console.WriteLine("{0} = {1}, {2} = {3}", nameof(x), x, nameof(y), y);
        Console.WriteLine("{0} = {1}, {2} = {3}", nameof(name1), name1, nameof(name2), name2);

        Swap(ref x, ref y);
        Swap(ref name1, ref name2);

        Console.WriteLine("\nAfter swap: ");

        Console.WriteLine("{0} = {1}, {2} = {3}", nameof(x), x, nameof(y), y);
        Console.WriteLine("{0} = {1}, {2} = {3}", nameof(name1), name1, nameof(name2), name2);
    }

    private static void Swap<T>(ref T a, ref T b) {
        (a, b) = (b, a);
    }
}