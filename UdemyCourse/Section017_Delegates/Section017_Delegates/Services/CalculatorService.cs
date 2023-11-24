namespace Section017_Delegates.Services; 

public class CalculatorService {

    public static double Max(double x, double y) {
        return Math.Max(x, y);
    }

    public static double Sum(double x, double y) {
        return x + y;
    }

    public static void ShowMax(double x, double y) {
        Console.WriteLine(Math.Max(x, y));
    }

    public static void ShowSum(double x, double y) {
        Console.WriteLine(x + y);
    }
}