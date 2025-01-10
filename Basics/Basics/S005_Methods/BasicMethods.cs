namespace Basics.S005_Methods;

public static class BasicMethods {
    public static void UserMain() {
        Console.WriteLine(Add(2, 5));
        Console.WriteLine(Add(2, 5, 7));
    }

    private static int Add(int a, int b) {
        return a + b;
    }

    private static int Add(int a, int b, int c) => a + b + c;
}