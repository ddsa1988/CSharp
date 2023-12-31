using Section017_Delegates.Services;

namespace Section017_Delegates;

public class Example001 {
    public delegate double BinaryOperation(double x, double y);

    public delegate void ShowOperation(double x, double y);

    public static void CallMain() {
        {
            BinaryOperation op = CalculatorService.Max;
            Console.WriteLine(op(2, 5));

            op = CalculatorService.Sum;
            Console.WriteLine(op(2, 5));
        }

        Console.WriteLine();

        {
            ShowOperation op = CalculatorService.ShowMax;
            op += CalculatorService.ShowSum;

            op(10, 20);
        }
    }
}