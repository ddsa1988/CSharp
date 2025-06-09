namespace Chapter004.NullableValueTypes;

public static class Example005 {
    public static void Run() {
        // Lifted equality operators handle nulls just like reference types do.
        // This means that two null values are equal.
        
        int? n1 = null;
        int? n2 = null;

        bool result = n1 == n2;
        
        Console.WriteLine("{0} = {1}", nameof(result), result);
    }
}