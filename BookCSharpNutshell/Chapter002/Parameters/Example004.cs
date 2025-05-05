namespace Chapter002.Parameters;

public static class Example004 {
    public static void UserMain() {
        // The ref modifier: the arguments are passed by reference

        int x = 10;
        int y = 20;

        string a = "Diego";
        string b = "Amanda";

        Console.WriteLine("Before swap: {0} = {1}, {2} = {3}", nameof(x), x, nameof(y), y);
        Console.WriteLine("Before swap: {0} = {1}, {2} = {3}", nameof(a), a, nameof(b), b);
        Console.WriteLine();

        Swap(ref x, ref y);
        Swap(ref a, ref b);

        Console.WriteLine("After swap: {0} = {1}, {2} = {3}", nameof(x), x, nameof(y), y);
        Console.WriteLine("After swap: {0} = {1}, {2} = {3}", nameof(a), a, nameof(b), b);
    }

    private static void Swap<T>(ref T a, ref T b) {
        (a, b) = (b, a);
    }
}