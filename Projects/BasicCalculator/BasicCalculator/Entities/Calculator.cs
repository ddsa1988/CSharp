namespace BasicCalculator.Entities;

public static class Calculator {
    public static double Operation(int opType, double a, double b) {
        return OpList.TryGetValue(opType, out var value) ? Calculate(value, a, b) : double.MinValue;
    }

    private static readonly Dictionary<int, Func<double, double, double>> OpList =
        new Dictionary<int, Func<double, double, double>>() {
            { 0, Add },
            { 1, Sub },
            { 2, Multiply },
            { 3, Div }
        };

    private static double Calculate(Func<double, double, double> func, double a, double b) {
        return func(a, b);
    }

    private static double Add(double a, double b) => a + b;
    private static double Sub(double a, double b) => a - b;
    private static double Multiply(double a, double b) => a * b;

    private static double Div(double a, double b) {
        if (b != 0) return a / b;

        Console.WriteLine("Impossible divide by zero.");
        return double.MinValue;
    }
}