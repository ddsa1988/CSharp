namespace Chapter002.NumericTypes;

public static class Example009 {
    public static void UserMain() {
        // Double and decimal precision

        const double a = 1.0;
        const double b = 6.0;

        const decimal c = (decimal)a / (decimal)b;
        const double d = a / b;

        Console.WriteLine("decimal => {0}M / {1}M = {2}M", a, b, c);
        Console.WriteLine("double => {0:F1} / {1:F1} = {2}", a, b, d);
    }
}