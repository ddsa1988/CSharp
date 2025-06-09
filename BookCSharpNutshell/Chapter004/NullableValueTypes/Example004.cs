namespace Chapter004.NullableValueTypes;

public static class Example004 {
    public static void Run() {
        // Operator Lifting
        // The Nullable<T> struct does not define operators such as <, >, or even ==.
        // The compiler borrows or “lifts” the less-than operator from the underlying value type.
        // Operator lifting means that you can implicitly use T’s operators on T?.

        int? a = 5;
        int? b = 10;

        // bool result = a < b => bool result = (a.HasValue && b.HasValue) ? (a.Value < b.Value) : false;
        bool result = a < b;
        Console.WriteLine("{0} = {1}", nameof(result), result);
    }
}