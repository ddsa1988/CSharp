namespace Basics.S005_Methods;

public static class MethodParameterIn {
    // The in modifier passes a value by reference (for both value and reference types) and
    // prevents the called method from modifying the values. It's used for large structs to
    // reduce memory usage.
    public static void UserMain() {
        Console.WriteLine(Add(2, 5));
    }

    private static int Add(in int x, in int y) {
        int result = x + y;

        //Error CS8331 Cannot assign to variable 'in int' because it is a readonly variable
        //x = 500;
        //y = 800;

        return result;
    }
}