using Section017_Delegates.Services;

namespace Section017_Delegates;

public class Program {
    
    public delegate double BinaryOperation(double x, double y);
    public delegate void ShowOperation(double x, double y);
    
    public static void Main(string[] arg) {

        {
            BinaryOperation op = CalculatorService.Max;
            Console.WriteLine(op(2,5));

            op = CalculatorService.Sum;
            Console.WriteLine(op(2,5));
        }

        Console.WriteLine();

        {
            ShowOperation op = CalculatorService.ShowMax;
            op += CalculatorService.ShowSum;

            op(10, 20);
        }
    }
}