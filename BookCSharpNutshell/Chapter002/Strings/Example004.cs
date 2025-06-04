namespace Chapter002.Strings;

public static class Example004 {
    public static void Run() {
        const string a = "test";
        const string b = "test";

        Console.WriteLine("\"{0}\" == \"{1}\" = {2}", a, b, a == b);
        Console.WriteLine("\"{0}\".Equals(\"{1}\") = {2}", b, a, a.Equals(b));
    }
}