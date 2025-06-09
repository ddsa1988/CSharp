namespace Chapter004.NullableValueTypes;

public static class Example006 {
    public static void Run() {
        /*
            When supplied operands of type bool? the & and | operators treat null as an
            unknown value. So, null | true is true because:
            • If the unknown value is false, the result would be true.
            • If the unknown value is true, the result would be true.
        */

        const string strNull = "null";
        
        bool? boolNull = null;
        bool? boolTrue = true;
        bool? boolFalse = false;

        Console.WriteLine("{0}:{1} | {2}:{3} => {4}", nameof(boolNull), strNull, nameof(boolTrue), boolTrue,
            boolNull | boolTrue);
        
        Console.WriteLine("{0}:{1} | {2}:{3} => {4}", nameof(boolNull), strNull, nameof(boolFalse), boolFalse,
            (boolNull | boolFalse) == null ? strNull : boolNull | boolFalse);
        
        Console.WriteLine();
        
        Console.WriteLine("{0}:{1} & {2}:{3} => {4}", nameof(boolNull), strNull, nameof(boolTrue), boolTrue,
            (boolNull & boolTrue) == null ? strNull : boolNull & boolTrue);
        
        Console.WriteLine("{0}:{1} & {2}:{3} => {4}", nameof(boolNull), strNull, nameof(boolFalse), boolFalse,
            boolNull & boolFalse);
    }
}