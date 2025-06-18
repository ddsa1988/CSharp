namespace Chapter004.Patterns;

public static class Example002 {
    public static void Run() {
        // Relational patterns

        const int number = 50;
        object obj = 100;

        if (obj is > number) {
            Console.WriteLine("{0} is greater than {1}", obj, number);
        }
    }

    private static string GetWeightCategory(decimal bmi) {
        return bmi switch {
            < 18.5M => "underweight",
            < 25M => "normal",
            < 30M => "overweight",
            _ => "obese"
        };
    }
}