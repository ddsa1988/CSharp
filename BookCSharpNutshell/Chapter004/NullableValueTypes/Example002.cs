namespace Chapter004.NullableValueTypes;

public static class Example002 {
    public static void Run() {
        // The conversion from T to T? is implicit, whereas from T? to T the conversion is explicit.

        int? a = 10;
        int b = 0;

        if (a.HasValue) {
            b = (int)a;
        }
        
        Console.WriteLine(b);
    }
}