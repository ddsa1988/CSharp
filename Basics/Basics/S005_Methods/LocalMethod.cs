namespace Basics.S005_Methods;

public static class LocalMethods {
    public static void UserMain() {
        Console.WriteLine(AddWrapper(5, 7));
        Console.WriteLine(AddWrapperWithStatic(5, 7));
    }

    private static int AddWrapper(int x, int y) {
        return Add();

        int Add() {
            // Add() can access the parent variables
            // You can change the value of the varibales
            return x + y;
        }
    }

    private static int AddWrapperWithStatic(int x, int y) {
        return Add(x, y);

        static int Add(int x, int y) {
            // Static Add() can't access the parent variables. It's safer.
            return x + y;
        }
    }
}