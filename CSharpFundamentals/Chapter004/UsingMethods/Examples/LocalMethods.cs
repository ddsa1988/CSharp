namespace UsingMethods.Examples;

internal static class LocalMethods {
    internal static void Run() {
        Console.WriteLine(AddWrapper1(10, 20));
        Console.WriteLine(AddWrapper2(10, 20));
        Console.WriteLine(AddWrapper3(10, 20));
    }

    private static int AddWrapper1(int a, int b) {
        return Add();

        int Add() {
            return a + b;
        }
    }

    private static int AddWrapper2(int a, int b) {
        return Add(a, b);

        int Add(int x, int y) {
            a++;
            return x + y;
        }
    }

    private static int AddWrapper3(int a, int b) {
        return Add(a, b);

        static int Add(int x, int y) {
            // a++; Error => A static local function cannot contain a reference to the main method variables
            return x + y;
        }
    }
}