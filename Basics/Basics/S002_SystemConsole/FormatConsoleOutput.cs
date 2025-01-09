namespace Basics.S002_SystemConsole;

public static class FormatConsoleOutput {
    public static void UserMain() {
        Console.WriteLine("My name is {0} and I was born in {1}/{2}/{3}.", "Diego", 22, 1, 1988);
        Console.WriteLine("{0}. Number {0}. Number {0}.", 10);
        Console.WriteLine("{3} {0} {2} {1}", 10, 20, 30, 40);
    }
}