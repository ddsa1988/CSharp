using Examples.YieldReturn.Models;

namespace Examples.YieldReturn;

public static class Example003 {
    public static void Run() {
        // Console.WriteLine(Math.Log(128, 2));
        // Console.WriteLine(Math.Pow(2, 6));

        var powerOfTwo = new PowerOfTwo();

        foreach (int value in powerOfTwo) {
            Console.Write($"{value} ");
        }
    }
}