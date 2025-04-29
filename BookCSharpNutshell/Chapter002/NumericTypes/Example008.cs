namespace Chapter002.NumericTypes;

public static class Example008 {
    public static void UserMain() {
        // Floating-point numbers special values

        const float zero = 0.0F;
        const float one = 1.0F;
        const float zeroMinus = -0.0F;
        const float oneMinus = -1.0F;

        const float a = one / zero;
        const float b = oneMinus / zero;
        const float c = one / zeroMinus;
        const float d = oneMinus / zeroMinus;
        const float e = zero / zero;
        const float f = (one / zero) - (one / zero);

        Console.WriteLine("{0} / {1} = {2}", one, zero, a);
        Console.WriteLine("{0} / {1} = {2}", oneMinus, zero, b);
        Console.WriteLine("{0} / {1} = {2}", one, zeroMinus, c);
        Console.WriteLine("{0} / {1} = {2}", oneMinus, zeroMinus, d);
        Console.WriteLine("{0} / {1} = {2}", zero, zero, e);
        Console.WriteLine("({0} / {1}) - ({2} / {3}) = {4}", one, zero, one, zero, e);
    }
}