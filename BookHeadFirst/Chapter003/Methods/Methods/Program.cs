namespace Methods;

public static class Program {
    public static void Main(string[] args) {
        PrintMsg("hello world");

        Console.WriteLine();

        Console.WriteLine($"Sum(1,2) = {Sum(1, 2)}\n");

        Console.WriteLine(Capitalize("THIS IS A SENTENCE."));
    }

    private static void PrintMsg(string msg) {
        Console.WriteLine($"This is the message: {msg}");
    }

    private static int Sum(int a, int b) {
        return a + b;
    }

    private static string Capitalize(string str) {
        return char.ToUpper(str[0]) + str.Substring(1).ToLower();
    }
}