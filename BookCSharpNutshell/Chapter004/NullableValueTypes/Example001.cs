namespace Chapter004.NullableValueTypes;

public static class Example001 {
    public static void Run() {
        // Reference types can represent a nonexistent value with a null reference. Value types,
        // however, cannot ordinarily represent null values.
        // To represent null in a value type, you must use a special construct called a nullable
        // type. A nullable type is denoted with a value type followed by the ? symbol.

        {
            int? a = null;

            if (a.HasValue) {
                Console.WriteLine(a.Value);
            }
        }
        
        {
            int? a = 20;

            if (a.HasValue) {
                Console.WriteLine(a.Value);
            }
        }
    }
}