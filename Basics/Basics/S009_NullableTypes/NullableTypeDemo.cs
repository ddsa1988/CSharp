namespace Basics.S009_NullableTypes;

public static class NullableTypeDemo {
    public static void UserMain() {
        int? intValue = null;

        if (intValue.HasValue)
            Console.WriteLine("The value is " + intValue.Value);
        else
            Console.WriteLine("The variable intValue is null.");

        if (intValue != null)
            Console.WriteLine("The value is " + intValue.Value);
        else
            Console.WriteLine("The variable intValue is null.");
    }
}