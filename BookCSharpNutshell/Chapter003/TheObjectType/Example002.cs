namespace Chapter003.TheObjectType;

public static class Example002 {
    public static void UserMain() {
        // Boxing converts a value-type instance to a reference-type instance
        // Unboxing converts a reference-type instance to a value-type instance

        const int a = 9;
        object obj1 = a;

        Console.WriteLine("{0} => Type = {1}, Value = {2}", nameof(obj1), obj1.GetType(), obj1);
        Console.WriteLine("{0} => Type = {1}, Value = {2}", nameof(a), a.GetType(), a);
        Console.WriteLine();

        object obj2 = 10; // Value is inferred to be of type int
        // long b = (long)obj2; // InvalidCastException
        long b = (int)obj2;

        Console.WriteLine("{0} => Type = {1}, Value = {2}", nameof(obj2), obj2.GetType(), obj2);
        Console.WriteLine("{0} => Type = {1}, Value = {2}", nameof(b), b.GetType(), b);
    }
}