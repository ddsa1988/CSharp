namespace Chapter002.FirstApp;

public static class Example002 {
    public static void Run() {
        const int n1 = 30;
        const int n2 = 100;

        int r1 = FeetToInches(n1);
        int r2 = FeetToInches(n2);

        Console.WriteLine(nameof(FeetToInches) + $"({n1}) : " + r1);
        Console.WriteLine(nameof(FeetToInches) + $"({n2}) : " + r2);
    }

    private static int FeetToInches(int feet) {
        int inches = feet * 12;
        return inches;
    }
}