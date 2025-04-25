namespace Chapter002.NumericTypes;

public static class Example001 {
    public static void UserMain() {
        // Predefined numeric types
        
        Console.WriteLine("Signed integer:");
        Console.WriteLine("{0} => from {1} to {2}",nameof(SByte), sbyte.MinValue, sbyte.MaxValue);
        Console.WriteLine("{0}=> from {1} to {2}", nameof(Int16), short.MinValue, short.MaxValue);
        Console.WriteLine("{0} => from {1} to {2}", nameof(Int32), int.MinValue, int.MaxValue);
        Console.WriteLine("{0} => from {1} to {2}", nameof(Int64), long.MinValue, long.MaxValue);
        
        Console.WriteLine("\nUnsigned integer:");
        Console.WriteLine("{0} => from {1} to {2}", nameof(Byte), byte.MinValue, byte.MaxValue);
        Console.WriteLine("{0} => from {1} to {2}", nameof(UInt16), ushort.MinValue, ushort.MaxValue);
        Console.WriteLine("{0} => from {1} to {2}", nameof(UInt32), uint.MinValue, uint.MaxValue);
        Console.WriteLine("{0} => from {1} to {2}", nameof(UInt64), ulong.MinValue, ulong.MaxValue);
        
        Console.WriteLine("\nReal:");
        Console.WriteLine("{0} => from {1} to {2}", nameof(Single), float.MinValue, float.MaxValue);
        Console.WriteLine("{0} => from {1} to {2}", nameof(Double), double.MinValue, double.MaxValue);
        Console.WriteLine("{0} => from {1} to {2}", nameof(Decimal), decimal.MinValue, decimal.MaxValue);
    }
}