namespace Basics.S009_NullableTypes;

public static class NullConditionalOperator {
    public static void UserMain() {
        int[]? numbers = null;

        if (numbers != null) Console.WriteLine("The array length is: " + numbers.Length);

        int length = numbers?.Length ?? 0;

        Console.WriteLine("The array length is: {0}.", length);
    }
}