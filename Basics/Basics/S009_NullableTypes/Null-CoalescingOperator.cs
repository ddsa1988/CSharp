namespace Basics.S009_NullableTypes;

public static class NullCoalescingOperator {
    public static void UserMain() {
        {
            const string? userInput = null;
            string value = userInput ?? "Default value.";

            Console.WriteLine(value);
        }

        Console.WriteLine();

        {
            const string? userInput = "This value is not null.";
            string value = userInput ?? "Default value.";

            Console.WriteLine(value);
        }
    }
}