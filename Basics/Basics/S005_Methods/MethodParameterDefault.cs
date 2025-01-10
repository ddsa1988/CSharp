namespace Basics.S005_Methods;

public static class MethodParameterDefault {
    // The default way a parameter is sent into a method is by value.
    public static void UserMain() {
        int x = 10;
        int y = 20;

        Console.WriteLine("Before call: X: {0}, Y: {1}", x, y);
        Console.WriteLine("Answer is: {0}", Add(x, y));
        Console.WriteLine("After call: X: {0}, Y: {1}", x, y);
    }

    private static int Add(int x, int y) {
        int result = x + y;

        x = 500;
        y = 800;

        return result;
    }
}