namespace Delegates.Examples;

internal static class FuncDelegate {
    public static void Run() {
        {
            Func<int, int, int> funcTarget = Add;
            int result = funcTarget(10, 20);
            Console.WriteLine(result);
        }

        Console.WriteLine();

        {
            Func<int, int, string> funcTarget = SumToString;
            string result = funcTarget(30, 20);
            Console.WriteLine(result);
        }
    }

    private static int Add(int x, int y) {
        return x + y;
    }

    private static string SumToString(int x, int y) {
        return (x + y).ToString();
    }
}